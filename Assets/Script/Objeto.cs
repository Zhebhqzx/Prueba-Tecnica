using UnityEngine;

public class ControlObjeto : MonoBehaviour
{
    private float limiteInferior = 0; // Altura mínima antes de eliminar el objeto
    private Color[] colores = {
        Color.yellow, Color.blue, Color.red, 
        new Color(0.5f, 0f, 0.5f), // Morado
        new Color(1f, 0.4f, 0.7f), // Rosa
        Color.green, 
        Color.cyan, 
        new Color(1f, 0.5f, 0f)  // Naranja
    };

    void Start()
    {
        // Asegurar que el objeto tiene un Collider, si no, agregar uno
        if (!GetComponent<Collider>())
        {
            gameObject.AddComponent<BoxCollider>(); // Agrega un BoxCollider si no tiene otro Collider
        }

        // Asignar un color aleatorio
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = colores[Random.Range(0, colores.Length)];
        }
    }

    void Update()
    {
        // Si el objeto cae por debajo del límite, se elimina
        if (transform.position.y < limiteInferior)
        {
            Debug.Log("Objeto eliminado por caída: " + gameObject.name);
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        // Si el objeto tiene la etiqueta "objeto", se elimina al hacer clic
        if (gameObject.CompareTag("Objeto"))
        {
            Debug.Log("Objeto eliminado al hacer clic: " + gameObject.name);
            Destroy(gameObject);
        }
    }
}



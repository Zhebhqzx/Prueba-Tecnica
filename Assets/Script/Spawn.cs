using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    public GameObject[] objetos; // Array de prefabs de objetos
    private float rangoX = 5; // La mitad del ancho de la plataforma (10/2)
    private float rangoZ = 5; // La mitad de la profundidad de la plataforma (10/2)
    private float altura = 10; // Altura a la que se generan los objetos
    private int maxObjetos = 10; // Número máximo de objetos a generar
    private int cantidadActual; // Variable para contar objetos en la plataforma

    void Start()
    {
        // Inicializar el contador correctamente en Start()
        cantidadActual = GameObject.FindGameObjectsWithTag("Objeto").Length;

        InvokeRepeating("SpawnRandomObject", 2.0f, 1.5f);
    }

    void Update()
    {
        // Actualizar cantidad de objetos en cada frame
        cantidadActual = GameObject.FindGameObjectsWithTag("Objeto").Length;
    }

    void SpawnRandomObject()
    {
        // Recalcular cantidad de objetos antes de generar uno nuevo
        cantidadActual = GameObject.FindGameObjectsWithTag("Objeto").Length;

        if (cantidadActual < maxObjetos) // Comprobar si aún se pueden generar más objetos
        {
            // Posición aleatoria dentro de la plataforma
            Vector3 spawnPos = new Vector3(Random.Range(-rangoX, rangoX), altura, Random.Range(-rangoZ, rangoZ));
            int objetoIndex = Random.Range(0, objetos.Length);

            // Instanciar el objeto
            Instantiate(objetos[objetoIndex], spawnPos, objetos[objetoIndex].transform.rotation);
        }

    }
}



using UnityEngine;
using TMPro;

public class ContadorEsferas : MonoBehaviour
{
    public TextMeshProUGUI contadorTexto;
    private int cantidadEsferas = 0;

    void Start()
    {
        ActualizarTexto();
    }

    void Update()
    {
        // Obtener la cantidad de esferas en la escena con la etiqueta "objeto"
        cantidadEsferas = GameObject.FindGameObjectsWithTag("Objeto").Length;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        contadorTexto.text = "Cant Objetos : " + cantidadEsferas;
    }
}


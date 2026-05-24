using UnityEngine;
using UnityEngine.UI;

public class SelectorDificultad : MonoBehaviour
{
    [Header("Botón Jugar")]
    public GameObject botonJugar;

    [Header("Dificultad seleccionada")]
    public static string dificultadActual = "";

    void Start()
    {
        // Ocultar el botón Jugar al iniciar la escena
        if (botonJugar != null)
            botonJugar.SetActive(false);
    }

    public void SeleccionarDificultad(string dificultad)
    {
        dificultadActual = dificultad;
        Debug.Log("Dificultad seleccionada: " + dificultad);

        // Mostrar el botón Jugar
        if (botonJugar != null)
            botonJugar.SetActive(true);
    }
}
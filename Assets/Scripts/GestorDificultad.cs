using UnityEngine;
using UnityEngine.UI;

public class GestorDificultad : MonoBehaviour
{
    public GameObject animacionFacil;
    public GameObject animacionNormal;
    public GameObject animacionDificil;

    void Start()
    {
        OcultarTodas();
    }

    public void MostrarFacil()
    {
        OcultarTodas();
        animacionFacil.SetActive(true);
    }

    public void MostrarNormal()
    {
        OcultarTodas();
        animacionNormal.SetActive(true);
    }

    public void MostrarDificil()
    {
        OcultarTodas();
        animacionDificil.SetActive(true);
    }

    void OcultarTodas()
    {
        animacionFacil.SetActive(false);
        animacionNormal.SetActive(false);
        animacionDificil.SetActive(false);
    }
}
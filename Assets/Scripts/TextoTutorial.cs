using UnityEngine;

public class TextoTutorial : MonoBehaviour
{
    public float tiempoVisible = 4f;

    void Start()
    {
        Invoke("OcultarTexto", tiempoVisible);
    }

    void OcultarTexto()
    {
        gameObject.SetActive(false);
    }
}

using UnityEngine;

public class ControladorEnlaces : MonoBehaviour
{
    public void AbrirPaginaWeb(string url)
    {
        Application.OpenURL(url);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegadorEscenas : MonoBehaviour
{
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
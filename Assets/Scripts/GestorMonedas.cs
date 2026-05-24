using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GestorMonedas : MonoBehaviour
{
    public static GestorMonedas Instancia;
    public TextMeshProUGUI textoMonedas;

    private int totalMonedas = 0;

    private void Awake()
    {
        // Patrón Singleton: solo existe una instancia de este gestor
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Cargar monedas guardadas al iniciar
        totalMonedas = 0;
        PlayerPrefs.SetInt("Monedas", 0);
        PlayerPrefs.Save();
        ActualizarTexto();
    }

    public void AgregarMoneda()
    {
        totalMonedas++;
        PlayerPrefs.SetInt("Monedas", totalMonedas);
        PlayerPrefs.Save();
        ActualizarTexto();
        if (totalMonedas >= 20)
        {
            PlayerPrefs.SetInt("Monedas", 0);
            PlayerPrefs.Save();
            SceneManager.LoadScene("EscenaVictoria");
        }
    }

    private void ActualizarTexto()
    {
        if (textoMonedas != null)
        {
            textoMonedas.text = "Monedas: " + totalMonedas;
        }
    }
}
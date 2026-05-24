using UnityEngine;
using TMPro;

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
        totalMonedas = PlayerPrefs.GetInt("Monedas", 0);
        ActualizarTexto();
    }

    public void AgregarMoneda()
    {
        totalMonedas++;
        PlayerPrefs.SetInt("Monedas", totalMonedas);
        PlayerPrefs.Save();
        ActualizarTexto();
    }

    private void ActualizarTexto()
    {
        if (textoMonedas != null)
        {
            textoMonedas.text = "Monedas: " + totalMonedas;
        }
    }
}
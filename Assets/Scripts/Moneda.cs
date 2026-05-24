using UnityEngine;

public class Moneda : MonoBehaviour
{
    public float tiempoReaparicion = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Sumar moneda al contador global
            GestorMonedas.Instancia.AgregarMoneda();
            // Ocultar la moneda y programar su reaparición
            gameObject.SetActive(false);
            Invoke("Reaparecer", tiempoReaparicion);
        }
    }

    private void Reaparecer()
    {
        gameObject.SetActive(true);
    }
}
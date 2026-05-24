using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform objetivo;       // El personaje al que seguirá la cámara
    public float velocidadSuave = 5f; // Qué tan suavemente sigue al jugador
    public Vector3 offset;           // Desplazamiento fijo desde el jugador

    void LateUpdate()
    {
        if (objetivo == null) return;

        // Posición destino: donde está el jugador + el desplazamiento
        Vector3 posicionDestino = new Vector3(
            objetivo.position.x + offset.x,
            objetivo.position.y + offset.y,
            transform.position.z   // La Z de la cámara nunca cambia en 2D
        );

        // Mover la cámara suavemente hacia esa posición
        transform.position = Vector3.Lerp(
            transform.position,
            posicionDestino,
            velocidadSuave * Time.deltaTime
        );
    }
}
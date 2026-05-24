using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;

    [Header("Detección de suelo")]
    public Transform puntoSuelo;
    public float radioSuelo = 0.2f;
    public LayerMask capaSuelo;

    private Rigidbody2D rb;
    private bool enSuelo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Detectar si está en el suelo
        enSuelo = Physics2D.OverlapCircle(puntoSuelo.position, radioSuelo, capaSuelo);

        // Movimiento horizontal
        float movimiento = 0f;
        if (Input.GetKey(KeyCode.A)) movimiento = -1f;
        if (Input.GetKey(KeyCode.D)) movimiento = 1f;

        rb.linearVelocity = new Vector2(movimiento * velocidad, rb.linearVelocity.y);

        // Salto
        if (Input.GetKeyDown(KeyCode.W) && enSuelo)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        }
    }
}

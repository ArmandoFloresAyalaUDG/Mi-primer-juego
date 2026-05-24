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
    private Animator animator;
    public bool mirandoDerecha = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        enSuelo = Physics2D.OverlapCircle(puntoSuelo.position, radioSuelo, capaSuelo);

        float movimiento = 0f;
        if (Input.GetKey(KeyCode.A)) movimiento = -1f;
        if (Input.GetKey(KeyCode.D)) movimiento = 1f;

        rb.linearVelocity = new Vector2(movimiento * velocidad, rb.linearVelocity.y);

        animator.SetFloat("velocidad", Mathf.Abs(movimiento));

        if (movimiento > 0f && !mirandoDerecha) Flip();
        if (movimiento < 0f && mirandoDerecha) Flip();

        if (Input.GetKeyDown(KeyCode.W) && enSuelo)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("disparar");
        }
    }

    void Flip()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 15f;
    public float tiempoVida = 3f;
    private float direccion = 1f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(velocidad * direccion, 0f);
        Destroy(gameObject, tiempoVida);
    }

    void Update() { }

    public void EstablecerDireccion(float dir)
    {
        direccion = dir;
        if (dir < 0)
        {
            Vector3 escala = transform.localScale;
            escala.x *= -1;
            transform.localScale = escala;
        }
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player")) return;
        Destroy(gameObject);
    }
}
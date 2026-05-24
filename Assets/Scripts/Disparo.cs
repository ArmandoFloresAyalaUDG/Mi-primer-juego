using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform puntoDisparo;

    private MovimientoJugador movimientoJugador;
    private Animator animator;
    private float cadencia = 0.3f;
    private float proximoDisparo = 0f;

    void Start()
    {
        movimientoJugador = GetComponent<MovimientoJugador>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= proximoDisparo)
        {
            Disparar();
            proximoDisparo = Time.time + cadencia;
        }
    }

    void Disparar()
    {
        animator.SetTrigger("disparar");
        float direccion = movimientoJugador.mirandoDerecha ? 1f : -1f;
        GameObject balaObj = Instantiate(prefabBala, puntoDisparo.position, Quaternion.identity);
        Bala bala = balaObj.GetComponent<Bala>();
        bala.EstablecerDireccion(direccion);
    }
}
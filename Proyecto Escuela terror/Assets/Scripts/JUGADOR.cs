using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class JUGADOR : MonoBehaviour
{
    public Animator anim;
    Rigidbody2D rb;
    public float velocidad;
    public float rotVelocidad;
    public bool cercaLocker;
    public bool escondido;
    public bool ultraVioleta;
    public Light2D linterna;
    public AudioSource pasos;
    public bool pieza1;
    public bool pieza2;
    public bool pieza3;
    void Start()
    {
       // Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();
        cercaLocker = false;
        escondido = false;
        ultraVioleta = false;
        pasos.enabled = false;
        pieza1 = false;
        pieza2 = false;
        pieza3 = false;

    }
    private void Update()
    {
        if (ultraVioleta)
        {
            linterna.color = Color.magenta;
        }
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            anim.Play("CaminaPersonaje");
            pasos.enabled = true;
        }
        else if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            anim.Play("CaminaParaAtras");
            pasos.enabled = true;
        }
        else
        {
            anim.Play("IdlePersonake");
            pasos.enabled = false;
        }
    }
    void FixedUpdate()
    {
        MoveRB(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void MoveRB(float x, float y)
    {
        rb.MovePosition(rb.position + (Vector2)transform.up * y * velocidad * Time.deltaTime);
        rb.MoveRotation(rb.rotation + rotVelocidad * -x * 360 * Time.deltaTime);
    }
    /*
     MOVEMENT SIN RB;
    void Update()
    {
        Movimiento(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // Llamamos la funcion y le asignamos el input
    }

    void Movimiento(float x, float y)
    {
        transform.position += transform.up * y * velocidad * Time.deltaTime; // movimiento en Y
        transform.Rotate(0, 0, rotVelocidad * -x * 360 * Time.deltaTime); // Rotacion
    }
    
    */


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUGADOR : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidad;
    public float rotVelocidad;
    public bool cercaLocker;
    public bool escondido;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cercaLocker = false;
        escondido = false;
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

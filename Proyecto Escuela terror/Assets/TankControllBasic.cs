using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankControllBasic : MonoBehaviour
{
    Rigidbody2D rb;
    public float rotVelocidad;
    public float velocidad;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaController : MonoBehaviour
{
    public GameObject cajaDestruida;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monstruo"))
        {
            Destroy(gameObject);
            Instantiate(cajaDestruida, transform.position, transform.rotation);
        }
    }
}

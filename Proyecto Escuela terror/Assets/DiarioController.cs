using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiarioController : MonoBehaviour
{
    public GameObject diario;
    void Start()
    {
        diario.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            diario.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        diario.SetActive(false);
    }
}


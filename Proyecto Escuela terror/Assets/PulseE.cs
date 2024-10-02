using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseE : MonoBehaviour
{
    public GameObject texto;
    private void Start()
    {
        texto.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            texto.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        texto.SetActive(false);
    }
}

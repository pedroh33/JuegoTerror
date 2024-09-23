using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlladorImagen : MonoBehaviour
{
    public GameObject imagen;

    // Start is called before the first frame update
    void Start()
    {
        imagen.SetActive(false);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            imagen.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        { 
            imagen.SetActive(false);
        }
    }
}

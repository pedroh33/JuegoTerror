using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOCKER : MonoBehaviour
{
    public JUGADOR jugador;
    public GameObject ImagenLocker;
    public bool escondido;
    public bool cercaLocker;
    void Start()
    {
        ImagenLocker.SetActive(false);
        escondido = false;
        cercaLocker = false;

    }

    // Update is called once per frame
    void Update()
    {
      
       if (Input.GetKeyDown (KeyCode.E) && cercaLocker)
        {
            
            if (!escondido)
            {
                ImagenLocker.SetActive(true);
                jugador.velocidad = 0;
                jugador.rotVelocidad = 0;
                escondido = true;
                Debug.Log("Entra");
                jugador.escondido = true;

            }
            else 
            {
                ImagenLocker.SetActive(false);
                jugador.velocidad = 4;
                jugador.rotVelocidad = 0.8f;
                escondido = false;
                Debug.Log("Sale");
                jugador.escondido = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            cercaLocker = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            cercaLocker = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOCKER : MonoBehaviour
{
    public JUGADOR jugador;
    public GameObject ImagenLocker;
    void Start()
    {
        ImagenLocker.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.E) && jugador.cercaLocker && !jugador.escondido) // esconderse en el locker
        {
            ImagenLocker.SetActive(true);
            jugador.velocidad = 0;
            jugador.escondido = true;
        }
        else if (jugador.escondido)
        {
            ImagenLocker.SetActive(false);
            jugador.velocidad = 2;
            jugador.escondido = false;
        }*/
       if (Input.GetKeyDown (KeyCode.E) && jugador.cercaLocker)
        {
            
            if (!jugador.escondido)
            {
                ImagenLocker.SetActive(true);
                jugador.velocidad = 0;
                jugador.rotVelocidad = 0;
                jugador.escondido = true;
                Debug.Log("Entra");

            }
            else 
            {
                ImagenLocker.SetActive(false);
                jugador.velocidad = 3;
                jugador.rotVelocidad = 0.5f;
                jugador.escondido = false;
                Debug.Log("Sale");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            jugador.cercaLocker = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            jugador.cercaLocker = false;
        }
    }
}

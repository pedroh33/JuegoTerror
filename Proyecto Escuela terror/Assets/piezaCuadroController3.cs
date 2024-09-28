using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piezaCuadroController3 : MonoBehaviour
{
    public JUGADOR jugador;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            jugador.pieza3 = true;
            Destroy(gameObject);
        }
    }
}

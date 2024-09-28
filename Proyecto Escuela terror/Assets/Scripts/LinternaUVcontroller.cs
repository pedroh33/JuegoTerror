using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaUVcontroller : MonoBehaviour
{
    public JUGADOR jugador;
//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            jugador.ultraVioleta = true;
            Destroy(gameObject);
        }
    }
}

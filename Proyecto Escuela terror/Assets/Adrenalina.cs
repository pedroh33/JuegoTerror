using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adrenalina : MonoBehaviour
{
    public JUGADOR jugador;
    public GameObject sonid;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sonid.SetActive(true);
            jugador.velocidad = 8;
            Destroy(gameObject);
        }
    }
}

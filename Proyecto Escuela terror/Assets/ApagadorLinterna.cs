using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagadorLinterna : MonoBehaviour
{
    public GameObject linterna;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ApagadorLinterna"))
        {
            linterna.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        linterna.SetActive(true);
    }
}

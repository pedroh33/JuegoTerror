using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TazasBotonesController : MonoBehaviour
{
    public GameObject canvas;

   
    void Start()
    {
        canvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            canvas.SetActive(true);
            Cursor.visible = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.SetActive(false);
        Cursor.visible = false;
    }
}

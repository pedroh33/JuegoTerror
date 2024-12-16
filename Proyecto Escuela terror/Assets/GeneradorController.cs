using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorController : MonoBehaviour
{
    public bool activado;
    public bool cercaGenerador;
    public GameObject luz;
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.SetActive(false);
        activado = false;
        cercaGenerador = false;
        luz.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(cercaGenerador && Input.GetKeyDown(KeyCode.E) && !activado)
        {
            luz.SetActive(true);
            activado = true;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            if (!activado)
            {
                cercaGenerador = true;
                texto.SetActive(true);
            }
            
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            cercaGenerador = false;
            texto.SetActive(false);
        }
    }
}

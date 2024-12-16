using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonController : MonoBehaviour
{
    public GameObject explosionelectrica;
    public GameObject audioElec;
    public GameObject mataMonstruo;
    public GameObject luzVerde;

    public GeneradorController gen1;
    public GeneradorController gen2;
    public GeneradorController gen3;
    public GeneradorController gen4;
    public GameObject luz;
    public GameObject texto;

    public bool prendido;
    private bool jugadorEnTrigger; 

    
    void Start()
    {
        explosionelectrica.SetActive(false);
        audioElec.SetActive(false);
        luzVerde.SetActive(false);
        mataMonstruo.transform.position = new Vector3(132.5f, 0.7f, 5.470638f);
        luz.SetActive(false);
        prendido = false;
        texto.SetActive(false);
        jugadorEnTrigger = false;
    }

  
    void Update()
    {
        if(gen1.activado && gen2.activado && gen3.activado && gen4.activado)
        {
            audioElec.SetActive(true);
            luzVerde.SetActive(true);
        }


        if (jugadorEnTrigger && !prendido && gen1.activado && gen2.activado && gen3.activado && gen4.activado)
        {
            texto.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                luz.SetActive(true);
                prendido = true;
                StartCoroutine(apagarLuz());
                mataMonstruo.transform.position = new Vector3(21.6f, 0.7f, 5.470638f);
                explosionelectrica.SetActive(true);
            }
        }
        else
        {
            texto.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            jugadorEnTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            jugadorEnTrigger = false; 
            texto.SetActive(false);
        }
    }

    public IEnumerator apagarLuz()
    {
        yield return new WaitForSeconds(1f);
        mataMonstruo.transform.position = new Vector3(132.5f, 0.7f, 5.470638f);
        luz.SetActive(false);
        prendido = false;
        explosionelectrica.SetActive(false);
    }
}

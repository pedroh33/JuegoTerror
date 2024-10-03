using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorGol : MonoBehaviour
{
    public float contadorGoles;
    public GameObject pelota;
    public AudioSource ding;
    void Start()
    {
        contadorGoles = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) // acepta que asume el trigger donde pongas el script
    {
        if (collision.CompareTag("Pelota"))
        {
            contadorGoles++;                                              //contador de goles y posicion de pelota
            pelota.transform.position = new Vector3(17.14f, 4.2026f, 0); 
            StartCoroutine(Ding());
        }                             
    }
    public IEnumerator Ding()
    {
        ding.enabled = true;
        yield return new WaitForSeconds(2f); //activa sonido espera 2 seg y vuelve a apagar
        ding.enabled = false;
    }
  
}

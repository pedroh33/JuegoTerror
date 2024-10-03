using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTRLLIMPIADOR : MonoBehaviour
{
    public ControladorGol contador;
    public GameObject pelota;
    public AudioSource error;
    private void OnTriggerEnter2D(Collider2D collision) // acepta que asume el trigger donde pongas el script
    {
        if (collision.CompareTag("Pelota"))  //Si toca el arco que no es el contador se resetea
        {
            contador.contadorGoles = 0; //reinicia contador
            pelota.transform.position = new Vector3(17.14f, 4.2026f, 0);
            StartCoroutine(Ding());
        }                                     
    }
    public IEnumerator Ding()
    {
        error.enabled = true;
        yield return new WaitForSeconds(2f);
        error.enabled = false;
    }
}

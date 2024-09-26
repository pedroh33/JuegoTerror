using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTRLLIMPIADOR : MonoBehaviour
{
    public ControladorGol contador;
    public GameObject pelota;
    private void OnTriggerEnter2D(Collider2D collision) // acepta que asume el trigger donde pongas el script
    {
        if (collision.CompareTag("Pelota"))  //cuando el trigger toca con pelota pasa:
        {
            contador.contadorGoles = 0; //reinicia contador
            pelota.transform.position = new Vector3(17.14f, 4.2026f, 0);
        }                                     
    }
}

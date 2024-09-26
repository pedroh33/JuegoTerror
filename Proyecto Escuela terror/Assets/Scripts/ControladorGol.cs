using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorGol : MonoBehaviour
{
    public float contadorGoles;
    public GameObject pelota;
    void Start()
    {
        contadorGoles = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) // acepta que asume el trigger donde pongas el script
    {
        if (collision.CompareTag("Pelota"))
        {
            contadorGoles++;
            pelota.transform.position = new Vector3(17.14f, 4.2026f, 0);
        }                             //cuando el trigger toca con pelota pasa:
    }
    void Update()
    {
        
    }
}

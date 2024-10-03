using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorpuzzlefutbol : MonoBehaviour
{
    public GameObject piezaCuadro;
    public GameObject pelota;
    public ControladorGol controlador; // Llama a controlador gol
    public bool Gano;
    public GameObject arco1;
    public GameObject arco2;
    public float xD;
    public float yD;
    public float xI;              //con estos floats no ahorramos cambiar el script de la posicion del arco y los cambiamos desde el editor
    public float yI;
   
    void Start()
    {
        Gano = false;
      
    }

    
    void Update()
    {
        if (controlador.contadorGoles == 0 ) //llamamamos a la variable controlado de contador de goles
        {
            arco1.transform.position = new Vector3(xD, yD , 0);
            arco2.transform.position = new Vector3(xI, yI , 0);
           
            
        }
        if (controlador.contadorGoles == 1)
        {
            arco1.transform.position = new Vector3(xD, yD, 0);
            arco2.transform.position = new Vector3(xI, yI, 0);
           
        }
        if (controlador.contadorGoles == 2)
        {
            arco1.transform.position = new Vector3(xI, yI, 0);
            arco2.transform.position = new Vector3(xD, yD, 0);
          
        }
        if (controlador.contadorGoles == 3)
        {
            arco1.transform.position = new Vector3(xI, yI, 0);
            arco2.transform.position = new Vector3(xD, yD, 0);
           //aca cambiamos la posicion de los arcos
        }
        if (controlador.contadorGoles == 4)
        {
            arco1.transform.position = new Vector3(xD, yD, 0);
            arco2.transform.position = new Vector3(xI, yI, 0); //aca volvimos a cambiar las posiciones
        
        }
        if (controlador.contadorGoles == 5)
        {
            if(piezaCuadro != null)
            {
                piezaCuadro.transform.position = new Vector3(17.22f, 4.17f, 0);
                Destroy(pelota);
                Gano = true;
                Debug.Log("Puzle de fulbo terminado");
            }

        }
    }
   
}

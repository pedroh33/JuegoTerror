using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CAMARAJUGADOR : MonoBehaviour
{
    public GameObject Jugador; //gameObject variable creada para rellenarla con objetos y las cargamos desde main camara
    public GameObject Camara;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 jugadorPosition = Jugador.transform.position; // creamos vector que adentro la posicion del jugador 
        Camara.transform.position = new Vector3 (jugadorPosition.x , jugadorPosition.y , Camara.transform.position.z); // Camara sigue la posicion del vector jugadorPosition
    }
}

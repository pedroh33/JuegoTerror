using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ContadorTaza : MonoBehaviour
{
    public bool apretado;
    public BotoneraTazas botonera;  // referencia a la BotoneraTazas

    // Start is called before the first frame update
    void Start()
    {
        apretado = false;
    }

    public void Apreta()
    {
        if (!apretado)
        {
            apretado = true;
            botonera.BotonPresionado(this);  // Avisar a la botonera
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotoneraTazas : MonoBehaviour
{
    public GameObject piezacuadro3;
    public ContadorTaza azul;
    public ContadorTaza verde;
    public ContadorTaza violeta;
    public ContadorTaza amarillo;

    private List<ContadorTaza> secuenciaCorrecta;
    private List<ContadorTaza> secuenciaActual;
    public bool secuenciaCompletada;

    // Start is called before the first frame update
    void Start()
    {
        secuenciaCorrecta = new List<ContadorTaza> { verde, azul, amarillo, violeta };
        secuenciaActual = new List<ContadorTaza>();
        secuenciaCompletada = false;
    }

    // Llamado cuando un bot�n es presionado
    public void BotonPresionado(ContadorTaza boton)
    {
        if (secuenciaCompletada)
            return;

        secuenciaActual.Add(boton);

        // Verificar si el bot�n es el correcto en la secuencia
        if (boton != secuenciaCorrecta[secuenciaActual.Count - 1])
        {
            Debug.Log("Orden incorrecto");
            ReiniciarSecuencia();
        }
        else if (secuenciaActual.Count == secuenciaCorrecta.Count)
        {
            SecuenciaCompletada();
        }
    }

    // Reiniciar la secuencia si es incorrecta
    private void ReiniciarSecuencia()
    {
        secuenciaActual.Clear();
        azul.apretado = false;
        verde.apretado = false;
        amarillo.apretado = false;
        violeta.apretado = false;
    }

    // Activar l�gica al completar la secuencia correctamente
    private void SecuenciaCompletada()
    {
        piezacuadro3.transform.position = new Vector3(57f, -3.8f, 0);
        secuenciaCompletada = true;
        Debug.Log("ORDEN CORRECTO");
        // Aqu� puedes activar un booleano o ejecutar otra acci�n
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotoneraTazas : MonoBehaviour
{
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

    // Llamado cuando un botón es presionado
    public void BotonPresionado(ContadorTaza boton)
    {
        if (secuenciaCompletada)
            return;

        secuenciaActual.Add(boton);

        // Verificar si el botón es el correcto en la secuencia
        if (boton != secuenciaCorrecta[secuenciaActual.Count - 1])
        {
            Debug.Log("Secuencia incorrecta. Reiniciando...");
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

    // Activar lógica al completar la secuencia correctamente
    private void SecuenciaCompletada()
    {
        secuenciaCompletada = true;
        Debug.Log("¡Secuencia completada correctamente!");
        // Aquí puedes activar un booleano o ejecutar otra acción
    }
}

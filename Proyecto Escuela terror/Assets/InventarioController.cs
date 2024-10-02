using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioController : MonoBehaviour
{
    public ControllerCuadro cuadro;
    public JUGADOR jugador;
    public GameObject pieza1;
    public GameObject pieza2;
    public GameObject pieza3;
    // Start is called before the first frame update
    void Start()
    {
        pieza1.SetActive(false);
        pieza2.SetActive(false);
        pieza3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador.pieza1 && !cuadro.completo1)
        {
            pieza1.SetActive(true);
        }
        else
        {
            pieza1.SetActive(false);
        }
        if (jugador.pieza2 && !cuadro.completo2)
        {
            pieza2.SetActive(true);
        }
        else
        {
            pieza2.SetActive(false);
        }
        if (jugador.pieza3 && !cuadro.completo3)
        {
            pieza3.SetActive(true);
        }
        else
        {
            pieza3.SetActive(false);
        }
    }
}

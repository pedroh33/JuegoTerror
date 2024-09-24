using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumerosControlador : MonoBehaviour
{
    public PuertaFinal clave;
    public TextMeshPro text;
    public JUGADOR jugador;
    // Start is called before the first frame update
   
    private void Update()
    {
        if (jugador.ultraVioleta)
        {
            text.SetText(clave.numeroRandom.ToString());
        }
        
    }
}

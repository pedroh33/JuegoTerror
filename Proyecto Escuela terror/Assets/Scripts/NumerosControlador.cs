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

    private void Start()
    {
        text.SetText(clave.numeroRandom.ToString());
    }
    private void Update()
    {
        if (jugador.ultraVioleta)
        {
            text.SetText(clave.numeroRandom.ToString());
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("LinternaCollider") && jugador.ultraVioleta)
        {
            text.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        text.enabled = false;
    }
}

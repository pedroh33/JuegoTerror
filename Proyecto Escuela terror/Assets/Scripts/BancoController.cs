using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BancoController : MonoBehaviour
{
    Animator anim;
    public bool volteado;
    [SerializeField] bool dentroCollider;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        volteado = false;
        dentroCollider = false;
        
    }
    private void Update()
    {
        if (volteado)
        {
            
            anim.Play("BancoRotaAtras");
        }
        else
        {

            anim.Play("BancoRotaAdelante");
        }
        if (dentroCollider)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (volteado)
                {
                    volteado = false;
                }
                else
                {
                    volteado = true;
                }
            }
          
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            dentroCollider = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            dentroCollider = false;
        }
    }
}

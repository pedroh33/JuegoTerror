using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Reloj : MonoBehaviour
{
    
    Animator anim;
    public bool apretando;
    
    void Start()
    {
        apretando = false;
        anim = GetComponentInChildren<Animator>();
        /*reloj.SetActive(false);*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.R))
        {
            apretando = true;
            /*reloj.SetActive(true);*/
        }
        else
        {
            apretando = false;
        }
        if (apretando)
        {
            
            anim.CrossFade("Salida", 0.2f);
        }
        else
        {
           
            anim.CrossFade("Entrada", 0.2f);
        }
    }
}

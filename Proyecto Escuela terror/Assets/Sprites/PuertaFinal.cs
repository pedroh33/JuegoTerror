using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaFinal : MonoBehaviour
{
    public GameObject boton;
    public int numeroRandom;
    public string codigo;
    public bool abierta;
    public AudioSource ding;
    private void Start()
    {
        numeroRandom = Random.Range(1000, 9999);
        boton.SetActive(false);
        abierta = false;
        ding.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            boton.SetActive(true);
            Cursor.visible = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            boton.SetActive(false);
            Cursor.visible = false;
        }
        
    }
    public void Boton1()
    {
        codigo = codigo + "1";
    }
    public void Boton2()
    {
        codigo = codigo + "2";
    }
    public void Boton3()
    {
        codigo = codigo + "3";
    }
    public void Boton4()
    {
        codigo = codigo + "4";
    }
    public void Boton5()
    {
        codigo = codigo + "5";
    }
    public void Boton6()
    {
        codigo = codigo + "6";
    }
    public void Boton7()
    {
        codigo = codigo + "7";
    }
    public void Boton8()
    {
        codigo = codigo + "8";
    }
    public void Boton9()
    {
        codigo = codigo + "9";

    }
    public void Boton0()
    {
        codigo = codigo + "0";
    }
    public void Okey()
    {
        if(numeroRandom.ToString() == codigo)
        {
            abierta = true;

        }
        else
        {
            codigo = null;
            StartCoroutine(Ding());
        }
    }
    public IEnumerator Ding()
    {
        ding.enabled = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
        ding.enabled = false;
    }
}

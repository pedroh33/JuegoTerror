using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteController : MonoBehaviour
{
    public JUGADOR jugador;
    public ControladorMostro timer;
    public AudioSource vieneChobisuiiii;
    public AudioSource sonidoNormal;
    // Start is called before the first frame update
    private void Start()
    {
        vieneChobisuiiii.enabled = false;
        sonidoNormal.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!jugador.escondido &&  timer.numeroRandom == 2 && timer.currentTime<0.01f)
        {
           SceneManager.LoadScene(2);
        }
        if(timer.numeroRandom == 2)
        {
            vieneChobisuiiii.enabled = true;
            sonidoNormal.enabled = false;
        }
        else
        {
            vieneChobisuiiii.enabled = false;
            sonidoNormal.enabled = true;
        }
    }

}

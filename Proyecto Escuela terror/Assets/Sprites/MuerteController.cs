using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteController : MonoBehaviour
{
    public JUGADOR jugador;
    public ControladorMostro timer;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if(!jugador.escondido &&  timer.numeroRandom == 2 && timer.currentTime<0.01f)
        {
           SceneManager.LoadScene(2);
        }
    }
}

using UnityEngine;

public class ControladorMostro : MonoBehaviour
{
    public GameObject agujaHora;
    public float startTime = 10f; 
    public float currentTime;
    public float numeroRandom;
    Animator anim;
   // public AudioSource sonidoMostro;

    void Start()
    {
        currentTime = startTime;
        anim = agujaHora.GetComponent<Animator>();
    }

    void Update()
    {                
        currentTime -= Time.deltaTime;
     
        if (currentTime <= 0)
        {
            if(numeroRandom != 2)
            {
                ResetTimer();
            }
            else
            {
                ResetTimerSinDos();
                
            }
        }
       
      
        if(numeroRandom != 2)
        {
            anim.Play("Default");           
        }
        else
        {
            anim.Play("Horas");            
        }
    }

    void ResetTimer()
    {
        currentTime = startTime; 
        numeroRandom=Random.Range(1, 10);
    }
    void ResetTimerSinDos()
    {
        currentTime = startTime; 
        numeroRandom = Random.Range(4, 8);
    }
}

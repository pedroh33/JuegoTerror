using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamerController : MonoBehaviour
{
    public GameObject video;
    public GameObject imagen;
    public TazasBotonesController panel;
    private void Start()
    {
        video.SetActive(false);
        imagen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("TriggerJugador") && panel.visto)
        {
            if(video!= null && imagen != null)
            video.SetActive(true);
            imagen.SetActive(true);
            Destroy(imagen, 1f);
            Destroy(video, 1f);
        }
    }
}

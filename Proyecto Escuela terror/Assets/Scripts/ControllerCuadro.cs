using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCuadro : MonoBehaviour
{
    public AudioSource puertasoni;
    public GameObject puerta;
    public GameObject canvas;
    public JUGADOR jugador;
    public GameObject pieza1;
    public GameObject pieza2;
    public GameObject pieza3;
    public bool completo1;
    public bool completo2;
    public bool completo3;

    bool dentro;
    // Start is called before the first frame update
    private void Start()
    {
        puertasoni.enabled = false;
        canvas.SetActive(false);
        pieza1.SetActive(false);
        pieza2.SetActive(false);
        pieza3.SetActive(false);
        completo1 = false;
        completo2 = false;
        completo3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dentro)
        {
            canvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (jugador.pieza1)
                {
                    pieza1.SetActive(true);
                    completo1 = true;
                }
                if (jugador.pieza2)
                {
                    pieza2.SetActive(true);
                    completo2 = true;
                }
                if (jugador.pieza3)
                {
                    pieza3.SetActive(true);
                    completo3 = true;
                }
            }
        }
        else
        {
            canvas.SetActive(false);
        }   
        if(completo1 && completo2 && completo3)
        {
            puerta.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -0.945f);
            puerta.transform.position = new Vector3(43.611f, -21.108f, 0);
            puertasoni.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador"))
        {
            dentro = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dentro = false;
        
    }
}

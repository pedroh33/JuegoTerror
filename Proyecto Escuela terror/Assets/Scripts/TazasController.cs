using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TazasController : MonoBehaviour
{
    public GameObject taza1;
    public GameObject taza1dentro;
    bool volteada;
    public bool dentro;
    // Start is called before the first frame update
    void Start()
    {
        taza1.SetActive(false);
        taza1dentro.SetActive(false);
        volteada = false;
        dentro = false;
    }
    private void Update()
    {
        if (dentro)
        {
            if (!volteada)
            {
                taza1.SetActive(true);
                taza1dentro.SetActive(false);
            }
            else
            {
                taza1.SetActive(false);
                taza1dentro.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerJugador") )
        {
            dentro = true;
            Cursor.visible = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dentro = false;
        volteada = false;
        taza1.SetActive(false);
        taza1dentro.SetActive(false);
        Cursor.visible = false;
    }

   public void Boton()
    {
        volteada = true;
    }

}

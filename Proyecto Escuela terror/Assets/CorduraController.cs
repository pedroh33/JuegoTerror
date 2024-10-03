using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CorduraController : MonoBehaviour
{
    public Slider slider;
    public JUGADOR cordura;
    public GameObject cerebro1;
    public GameObject cerebro2;
    public GameObject cerebro3;

    // Start is called before the first frame update
    void Start()
    {
        cordura.cordura = 100;
        StartCoroutine(CargarVida());
        StartCoroutine(BajarCordura());

    }

    // Update is called once per frame
    void Update()
    {
     if(cordura.cordura < 0)
        {
            SceneManager.LoadScene(1);
        }
        float fillValue = cordura.cordura / 100;
        slider.value = fillValue;

        if (cordura.cordura >= 75)
        {
            cerebro1.SetActive(true);
            cerebro2.SetActive(false);
            cerebro3.SetActive(false);
        }else if (cordura.cordura<=74 && cordura.cordura >= 25)
        {
            cerebro1.SetActive(false);
            cerebro2.SetActive(true);
            cerebro3.SetActive(false);
        }
        else
        {
            cerebro1.SetActive(false);
            cerebro2.SetActive(false);
            cerebro3.SetActive(true);
        }

    }
    public IEnumerator BajarCordura()
    {
        while (true)
        {
            if (cordura.escondido)
            {
                cordura.cordura -= 2;
                yield return new WaitForSeconds(1);
            }
            else
            {
                yield return null;
            }
        }

    }
    public IEnumerator CargarVida()
    {
        while (true)
        {
            if (cordura.cordura < 100)
            {
                cordura.cordura += 1;
                yield return new WaitForSeconds(4);
            }
            else
            {
                yield return null;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    bool coi;
    public bool abierto;
    public GameObject controles;
    public TextMeshProUGUI cabecera;
    public TextMeshProUGUI texto1;
    public TextMeshProUGUI texto2;
    public TextMeshProUGUI texto3;
    public TextMeshProUGUI texto4;
    private void Start()
    {
        abierto = false;
    }
    private void Update()
    {
        if (coi)
        {
            cabecera.text = "Controles";
            texto1.text = "WASD Movimiento";
            texto2.text = "E para interactuar";
            texto3.text = "R para ver RELOJ";
            texto4.text = "Click Izq para interactuar";
        }
        else
        {
            cabecera.text = "Integrantes";
            texto1.text = "Pedro Hidalgo";
            texto2.text = "Ivan Belbrun";
            texto3.text = "Alejandro Cordoba";
            texto4.text = "Nahuel Carro Costa";
        }



        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene(5);
        }
        if (abierto)
        {
            controles.SetActive(true);
        }
        else
        {
            controles.SetActive(false);
        }
    }
    public void Cambiar()
    {
        SceneManager.LoadScene(4);
    }
    public void AbrirMenu()
    {
        coi = true;
        if (abierto)
        {
            abierto = false;
        }
        else
        {
            abierto = true;
        }
    }
    public void AbrirMenuIntegrantes()
    {
        coi = false;
        if (abierto)
        {
            abierto = false;
        }
        else
        {
            abierto = true;
        }
    }
    public void Salir()
    {
        Application.Quit();
    }
}

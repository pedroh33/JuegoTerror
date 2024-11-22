using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public bool abierto;
    public GameObject controles;
    private void Start()
    {
        abierto = false;
    }
    private void Update()
    {
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
        if (abierto)
        {
            abierto = false;
        }
        else
        {
            abierto = true;
        }
    }
}

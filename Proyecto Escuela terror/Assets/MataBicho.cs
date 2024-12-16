using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MataBicho : MonoBehaviour
{
    public GameObject bicho;
    public GameObject quemado;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monstruo")){

            quemado.transform.position = new Vector3(20.87f, -1.42f, 0f);
            Destroy(bicho);
            StartCoroutine(Cambio());
        }
    }

    public IEnumerator Cambio()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MataBicho : MonoBehaviour
{
    public GameObject bicho;
    public GameObject quemado;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monstruo")){

            quemado.transform.position = new Vector3(20.87f, -1.42f, 0f);
            Destroy(bicho);
            StartCoroutine(Cambio());
            anim.Play("Fadeout");
        }
    }

    public IEnumerator Cambio()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(3);
    }
}



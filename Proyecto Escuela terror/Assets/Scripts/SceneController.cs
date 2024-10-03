using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CambiarEscena());
    }

    public IEnumerator CambiarEscena()
    {
        yield return new WaitForSeconds(9);
        SceneManager.LoadScene(0);
    }
}

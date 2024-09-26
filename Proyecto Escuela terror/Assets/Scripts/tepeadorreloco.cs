using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tepeadorreloco : MonoBehaviour
{
    public GameObject bocha;
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pelota"))
        {
            bocha.transform.position = new Vector3(17.14f, 4.2026f, 0);
        }
    }
}

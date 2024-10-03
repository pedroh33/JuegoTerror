using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickerController : MonoBehaviour
{
    public Transform ticker;
    public GameObject prefab;
    public JUGADOR jugador;
    public AudioSource screamer;
    public AudioSource risa;
    public Animator anim;
    public Transform target;
    public float speed = 5f;
    public float stoppingDistance = 1f;
    private Rigidbody2D rb;

    void Start()
    {
        screamer.enabled = false;
        risa.enabled = false;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(InstantiatePrefabAtRandomTimes());
    }

    void Update()
    {
        if (target != null)
        {

            float distance = Vector2.Distance(transform.position, target.position);


            if (distance > stoppingDistance)
            {

                Vector2 direction = (target.position - transform.position).normalized;
                rb.velocity = direction * speed;


                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
                rb.rotation = angle;
            }
            else
            {

                rb.velocity = Vector2.zero;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            jugador.cordura -= 60;
            screamer.enabled = true;
            anim.Play("pantallaroja");
            Destroy(gameObject, 0.5f);
        }
        if (collision.CompareTag("LinternaCollider"))
        {
            risa.enabled = true;
            Destroy(gameObject, 0.5f);
        }

    }

    IEnumerator InstantiatePrefabAtRandomTimes()
    {
        while (true)
        {
            // Wait for a random amount of time between minTime and maxTime
            float randomWaitTime = Random.Range(5f, 15f);
            yield return new WaitForSeconds(randomWaitTime);

            // Check if prefab and moving object are assigned
            if (prefab != null && gameObject != null)
            {
                // Instantiate the prefab at the moving object's position and rotation
                Instantiate(prefab, ticker.position, ticker.rotation);
            }
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickerController : MonoBehaviour
{
//DISCLAIMER : ESTO SE VA A CAMBIAR CUANDO LLEGUE LA CLASE QUE EXPLICAN ESTO (AHORA FUE COMPLETAMENTE ROBADO DE STACKOVERFLOW)

    public Transform target;    // The object to chase
    public float speed = 5f;    // Speed of the chasing object
    public float stoppingDistance = 1f; // Distance at which the object will stop chasing
    private Rigidbody2D rb;     // Rigidbody2D for movement

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Get the Rigidbody2D component
    }

    void Update()
    {
        if (target != null)
        {
            // Calculate the distance to the target
            float distance = Vector2.Distance(transform.position, target.position);

            // If the distance is greater than the stopping distance, move towards the target
            if (distance > stoppingDistance)
            {
                // Move towards the target
                Vector2 direction = (target.position - transform.position).normalized;
                rb.velocity = direction * speed;

                // Optionally rotate the object to face the target
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
                rb.rotation = angle;
            }
            else
            {
                // Stop the object when it reaches the stopping distance
                rb.velocity = Vector2.zero;
            }
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }

    }



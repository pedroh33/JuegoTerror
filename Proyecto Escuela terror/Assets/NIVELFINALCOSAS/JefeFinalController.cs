using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JefeFinalController : MonoBehaviour
{
    public GameObject audioGrito;
    public GameObject audioArranca;
    public SpriteRenderer spriteJugador;
    public JUGADOR jugador;
    public Transform target;
    private Rigidbody2D rb;
    public float speed = 5f;
    public float stoppingDistance = 1f;
    Animator anim;
    public bool atrapado;
    private string currentAnimation; // To track the current animation
    public Animator sangre;

    // Start is called before the first frame update
    void Start()
    {
        audioGrito.SetActive(false);
        atrapado = false;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentAnimation = "AnimacionCaminaJefe"; // Default animation
        anim.Play(currentAnimation); // Play the default animation
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

        if (atrapado && currentAnimation != "JefeMata")
        {
            audioGrito.SetActive(true);
            audioArranca.SetActive(true);
            ChangeAnimation("JefeMata");
            spriteJugador.enabled = false;
            jugador.velocidad = 0;
            sangre.Play("AnimacionSangre");
            StartCoroutine(CambiarEscena());
        }
        else if (!atrapado && currentAnimation != "AnimacionCaminaJefe")
        {
            ChangeAnimation("AnimacionCaminaJefe");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ColliderMonstruo"))
        {
            atrapado = true;
        }
        
        
        
    }
    public IEnumerator CambiarEscena()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(2);
    }

    private void ChangeAnimation(string newAnimation)
    {
        currentAnimation = newAnimation;
        anim.Play(newAnimation);
    }
}

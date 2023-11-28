using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    private float Move;
    private Rigidbody2D rb;
    bool facingright = true;
    private ParticleSystem particulas;
    private Animator animator; // Agrega una referencia al Animator

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Obtén el Animator
    }

    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Move * speed, rb.velocity.y);
        if (Move < 0 && facingright)
        {
            flip();
        }
        if (Move > 0 && !facingright)
        {
            flip();
        }

        // Control de la animación
        if (Move != 0)
        {
            animator.SetBool("isRun", true); // Activa la animación si se está moviendo
        }
        else
        {
            animator.SetBool("isRun", false); // Desactiva la animación si no se está moviendo
        }
    }

    void flip()
    {
        facingright = !facingright;
        transform.Rotate(0, 180, 0);
    }

    void Play()
    {
        particulas.Play();
    }
}

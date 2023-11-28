using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltar : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGrounded;
    private Animator animator; // Referencia al Animator

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Obtén el Animator
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapPoint(groundCheck.position, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump(); // Llama a la función Jump() si está en el suelo
        }

        // Control de la animación
        animator.SetBool("isJump", !isGrounded);
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}

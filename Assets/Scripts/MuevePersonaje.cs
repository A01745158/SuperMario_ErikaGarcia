using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    public float velocidadX = 10;    // Horizontal (para movimiento horizontal) 
    public float velocidadY = 10;    // Vertical (para el salto) 
    // El componente Rigidbody del personaje (para física) 
    private Rigidbody2D rb;

    //Animator
    private Animator animator; //para acceder a velocidad

    //Animator2
    private Animator animator2; //para acceder a velocidad

    //Renderer
    private SpriteRenderer rendererMario; //para flipX


    // Start is called before the first frame update 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator2 = GetComponent<Animator>();
        rendererMario = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
        //Cambiar animación con el parámetro velocidad
        animator.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));
        //Cambiar animación con el parámetro velocidad
        animator2.SetFloat("velocidady", Mathf.Abs(rb.velocity.y));
        //Cambiar dirección por el signo
        rendererMario.flipX = rb.velocity.x > 0;
        //Cambiar dirección por el signo
        //rendererMario.flipX = rb.velocity.y > 0;
    }
}
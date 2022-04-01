using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveVillano : MonoBehaviour
{
    public float velocidadX = 5;    // Horizontal (para movimiento horizontal) 
    public float velocidadY = 1;    // Vertical (para el salto)
    public float counter = 1;
    // El componente Rigidbody del personaje (para física) 
    private Rigidbody2D rb;

    // Start is called before the first frame update 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // InvokeRepeating("FixedUpdate", 0.0f, 10); 
    }

    private void FixedUpdate()
    //IEnumerator Fade()
    {
        
    if (counter < 80)
        {
            rb.velocity = new Vector2(velocidadX, rb.velocity.y);
        }
    if (counter > 80)
        {
            rb.velocity = new Vector2(-velocidadX, rb.velocity.y);
        }
    if (counter > 160)
        {
            counter = 0;
        }
        counter = counter + 1;
    }
    
}
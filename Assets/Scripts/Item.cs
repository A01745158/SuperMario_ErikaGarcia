using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Autor: Erika Marlene García Sánchez
 * Detecta las colisiones con el personaje
*/
public class Item : MonoBehaviour
{
    [SerializeField]
    private AudioSource efectoMoneda;

    // Con esto sabremos contra quien chocó el collider (villano o main)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) /* El tag es su identificador (cadena)*/
            /*Si colisionó con el jugador*/
        {
            //Hacer visible la explosión
            //Se pone 0 para referirnos a su primer hijo (su único)
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            //gameObject.transform.GetChild(0) --> transform de la explosión
            //.gameObject.SetActive(true); --> referirnos al objeto explosión y activarlo

            GetComponent<SpriteRenderer>().enabled = false; //Desactivar la moneda

            // Destroy(collision.gameObject, 0.3f); destruye al personaje
            Destroy(gameObject, 0.3f); //Destruye el item

            //print("Hay colisión!"); se usa para saber si cumple con la función

            //Cuenta monedas recolectadas
            SaludPersonaje.instance.monedas++;
            HUD.instance.ActualizarContadorMonedas();

            //EFECTO SONIDO
            efectoMoneda.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Erika Marlene García Sánchez
 * Detecta las colisiones con el personaje y resta vidas
*/

public class ChocaPersonaje : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Objeto tipo SaludPersonaje
            SaludPersonaje.instance.vidas--;
            HUD.instance.ActualizarVidas();

            if (SaludPersonaje.instance.vidas == 0)
            {
                //Destruye el personaje tras perder 3 vidas
                Destroy(collision.gameObject, 0.1f);
            }
        }
    }
}

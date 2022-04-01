using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Autor: Erika Marlene García Sánchez
Propósito: Mantiene información sobre las vidas del personaje
 */
public class SaludPersonaje : MonoBehaviour
{
    //empieza con 3 vidas
    public int vidas = 3;

    //empieza con 0 monedas
    public int monedas = 0;

    //instancia que representa las características (las vidas)
    public static SaludPersonaje instance;

    //Se llama antes que Start, al iniciar la app
    private void Awake()
    {
        //Al decir this se refiere al objeto que usa la clase
        instance = this;
    }
}

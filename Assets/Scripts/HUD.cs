using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
Autora: Erika Marlene García Sánchez
Objetivo: manipular las imágenes de vida (corazones) para que representen la salud del personaje
 */

public class HUD : MonoBehaviour
{
    public static HUD instance;
    public Image Imagen1;
    public Image Imagen2;
    public Image Imagen3;

    public TextMeshProUGUI txtMonedas;

    private void Awake()
    {
        //El objeto se asigna a instance
        instance = this;
    }

    public void Reanudar()
    {
        MenuPausa.instance.Pausar();
    }

    //Método que refresca las vidas (imágenes de corazones)
    public void ActualizarVidas()
    {
        int vidas = SaludPersonaje.instance.vidas;
        switch (vidas)
        {
            case 2:
                Imagen3.enabled = false;
                break;
            case 1:
                Imagen2.enabled = false;
                break;
            case 0:
                Imagen1.enabled = false;
                break;
        }
    }

    public void ActualizarContadorMonedas()
    {
        int monedas = SaludPersonaje.instance.monedas;
        txtMonedas.text = monedas.ToString();
    }
}

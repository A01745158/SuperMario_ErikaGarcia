using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autora: ERika Marlene García Sánchez
 * Objetivo: Comportamiento del menú pausa.
*/
public class MenuPausa : MonoBehaviour
{
    [SerializeField]//Para acceder a él desde Unity

        private GameObject panelPausa;
        public bool estaPausado = false;

    public static MenuPausa instance;

    private void Awake()
    {
        instance = this;
    }

    public void Pausar()
    {
        estaPausado = !estaPausado;
        panelPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0 : 1;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pausar();
        }
    }
}

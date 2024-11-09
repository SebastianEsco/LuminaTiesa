using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llegada : MonoBehaviour
{
    public GameObject posicionDeLlegada;
    bool llego;

    private void Update()
    {
        if(Math.Abs(transform.position.x - posicionDeLlegada.transform.position.x) < 2)
        {
            if (!llego)
            {
                llego = true;
                GameObject.Find("ListaDeTareas").GetComponent<ListaChecks>().MisionCumplida(); //check lista
                GameObject.Find("Manager").GetComponent<MovimientoPrueba>().ActivarBarrilesConFisicas(); //Activar barriles con fisicas
                GameObject.Find("Manager").GetComponent<MovimientoPrueba>().MovimientoFalse(); 
                
            }
        }
    }
}

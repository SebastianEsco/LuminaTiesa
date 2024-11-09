using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efecto : MonoBehaviour
{
    public float tiempoDeDesvanecido;
    float timer;
    public Material[] materiales;
    public bool aparecer, desaparecer;
    public float cantidadDeDesvanecido;

    public Light luz;

    Manager manager;

    public bool reinciarTiempo;

    private void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        luz.intensity = 0;
    }


    private void Update()
    {

        if (manager.florEspecial && cantidadDeDesvanecido < 0.5f)
        {
            luz.intensity += 0.075f * Time.deltaTime;
        }

        if (aparecer)
        {
            Aparecer();
            
        }
        else if (desaparecer)
        {
            
            Desvancer();
        }
        if(reinciarTiempo)
        {
            timer = 0;
        }
    }

    public void Desvancer()
    {
        if (timer < tiempoDeDesvanecido)
        {
            timer += Time.deltaTime;
        }
        float t = (tiempoDeDesvanecido - timer) / tiempoDeDesvanecido;

        cantidadDeDesvanecido = Mathf.Lerp(1, 0, t);

        foreach (var material in materiales)
        {
            material.SetFloat("_DisolvedAmount", cantidadDeDesvanecido);
        }





    }

    public void Aparecer()
    {
        if (timer < tiempoDeDesvanecido)
        {
            timer += Time.deltaTime;
        }
        float t = (tiempoDeDesvanecido - timer) / tiempoDeDesvanecido;

        cantidadDeDesvanecido = Mathf.Lerp(0, 1, t);
        foreach (var material in materiales)
        {
            material.SetFloat("_DisolvedAmount", cantidadDeDesvanecido);
        }
    }

    public void Activar()
    {
        foreach (var material in materiales)
        {
            material.SetFloat("_DisolvedAmount", 1);
        }
    }

    public void Desactivar()
    {
        if (!manager.florEspecial)
        {
            manager.floresCogidas++;
            foreach (var material in materiales)
            {
                material.SetFloat("_DisolvedAmount", 0);
            }
        }
        
    }

    public void Invocar()
    {
        timer = 0;
        aparecer = true;
        desaparecer = false;
    }

    public void Exorcizar()
    {
        timer = 0;
        aparecer = false;
        desaparecer = true;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPescado : MonoBehaviour
{

    public float tiempoDeMovimiento;
    public float velocidad;
    float timer;
    Vector3 posicionInicial;

    private void Start()
    {
        posicionInicial = transform.localPosition;
        
    }
    private void FixedUpdate()
    {
        float posz = transform.localPosition.z + velocidad;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, posz );

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            transform.localPosition = posicionInicial;
            timer = tiempoDeMovimiento;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    MovimientoPrueba mov;
    public ParticleSystem remoSalpicadura;

    private void Awake()
    {
        mov = GameObject.Find("Manager").GetComponent<MovimientoPrueba>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Remo"))
        {
            mov.Remado();
            remoSalpicadura.Play();
        }

        
    }
}

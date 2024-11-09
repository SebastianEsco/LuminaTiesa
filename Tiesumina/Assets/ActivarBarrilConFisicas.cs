using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarBarrilConFisicas : MonoBehaviour
{
    public GameObject[] cosasADesactivar;
    public GameObject barrilConFisicas;

    public void ActivacionBarrilConFisicas()
    {
        foreach (var componente in cosasADesactivar)
        {
            componente.SetActive(false);
        }
        barrilConFisicas.SetActive(true);
    }
}

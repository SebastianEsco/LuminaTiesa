using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilTirado : MonoBehaviour
{
    public GameObject barrilConFisicas, listaDeTareas;
    private void Update()
    {
        if(barrilConFisicas.transform.localPosition.z >= 0.5f)
        {
            Debug.Log("DE LOCOOOS");
            listaDeTareas.GetComponent<ListaChecks>().BarrilTirado();
            Destroy(gameObject);
        }
    }
}

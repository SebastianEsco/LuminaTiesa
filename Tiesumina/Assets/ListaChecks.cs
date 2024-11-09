using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaChecks : MonoBehaviour
{
    public GameObject[] texturas;
    int contador;
    int contadorBarriles;

    public void Start()
    {
        foreach (var item in texturas)
        {
            item.SetActive(false);
        }
        texturas[0].SetActive(true);
    }
    public void MisionCumplida()
    {
        if(contador < texturas.Length)
        {
            texturas[contador].SetActive(false);
            contador++;
            texturas[contador ].SetActive(true);
        }
    }

    public void BarrilTirado()
    {
        contadorBarriles++;
        if(contadorBarriles == 2)
        {
            MisionCumplida();
            GameObject.Find("Agua").GetComponent<AguaTurbia>().cambio = true;
        }
    }
}

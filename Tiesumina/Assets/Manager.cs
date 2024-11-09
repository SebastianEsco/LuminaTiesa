using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int floresTotales;
    public int floresCogidas;

    public bool florEspecial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(floresTotales == floresCogidas)
        {
            florEspecial = true;
        }
    }
}

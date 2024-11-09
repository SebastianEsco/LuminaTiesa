using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RespawnEpico : MonoBehaviour
{
    public GameObject puntoDeRespawn;
    public bool isRemo;

    float cooldown = 3;
    float timer;
    
    private void Update()
    {
        if(transform.position.y <= -2)
        {
            

            

            if (isRemo)
            {
                //Instanciando
                Instantiate(gameObject, puntoDeRespawn.transform.position, Quaternion.identity);
                Destroy(gameObject);

            }
            else
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                transform.position = puntoDeRespawn.transform.position;

            }
        }
    }

}

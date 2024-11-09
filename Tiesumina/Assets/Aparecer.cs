using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
{
    public bool aparecer;
    public float speed;
    public float alturaDeseada;

    private void Update()
    {
        if(aparecer)
        {
            if(alturaDeseada > transform.position.y)
            {
                float y = transform.position.y;
                y += speed * Time.deltaTime;
                transform.position = new Vector3(transform.position.x, y, transform.position.z);
            }
             
        }
    }
}

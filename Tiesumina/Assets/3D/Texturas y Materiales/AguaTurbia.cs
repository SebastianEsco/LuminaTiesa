using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaTurbia : MonoBehaviour
{

    public bool cambio = false;
    public Material material;

    //Luz
    public Light mainLight;
    public float intensityIncial, intensityFinal;

    //uv speed 1
    public float uvspeedIncial, uvspeedFinal;
    float uvspeed;

    //Color
    public Color colorInicial, ColorFinal;
    Color color;

    //foam amount
    public float foamCullInicial, foamCullFinal;
    float foamCull;

    //Displacement x
    public float displacementSpeedxIncial, displacementSpeedxFinal;
    float displacementSpeedx;

    //Displacement y
    public float displacementSpeedyIncial, displacementSpeedyFinal;
    float displacementSpeedy;

    Vector2 displacementSpeed;

    //foam bubble speed
    public float foamSpeedInicial, foamSpeedFinal;
    float foamSpeed;

    public float tiempoDeCambio;
    float timer, lerpTime;
    

    private void Start()
    {
        //Setteo inicial de variables
        material.SetFloat("_uvSpeed", uvspeedIncial);
        material.SetColor("Color_2ac92d9cb09c47e5afeb9150620d0716", colorInicial);
        material.SetFloat("_foamCull",foamCullInicial);
        material.SetVector("_DisplacementSpeed", new Vector2(displacementSpeedxIncial, displacementSpeedyIncial));
        material.SetFloat("Vector1_b2dd9f09eb8342fea343968799f0acca", foamSpeedInicial);
    }
    void Update()
    {
        if (cambio)
        {
            if (timer < tiempoDeCambio)
            {
                timer += Time.deltaTime;
            }
            else
            {
                GameObject.Find("Manager").GetComponent<MovimientoPrueba>().AparecerGuardian();
            }
            lerpTime = timer / tiempoDeCambio;

            mainLight.intensity = Mathf.Lerp(intensityIncial, intensityFinal, lerpTime);

            uvspeed = Mathf.Lerp(uvspeedIncial, uvspeedFinal, lerpTime);
            material.SetFloat("_uvSpeed", uvspeed);

            color = Color.Lerp(colorInicial, ColorFinal, lerpTime);
            material.SetColor("Color_2ac92d9cb09c47e5afeb9150620d0716", color);

            foamCull = Mathf.Lerp(foamCullInicial, foamCullFinal, lerpTime);
            material.SetFloat("_foamAmount", foamCull);

            displacementSpeed = new Vector2(Mathf.Lerp(displacementSpeedxIncial, displacementSpeedxFinal, lerpTime),
                                             Mathf.Lerp(displacementSpeedyIncial, displacementSpeedyFinal, lerpTime));
            material.SetVector("_DisplacementSpeed", displacementSpeed);

            foamSpeed = Mathf.Lerp(foamSpeedInicial, foamSpeedFinal, lerpTime);
            material.SetFloat("Vector1_b2dd9f09eb8342fea343968799f0acca", foamSpeed);
        }
    }

    

    
}

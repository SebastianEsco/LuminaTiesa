using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPrueba : MonoBehaviour
{

    bool ambosPuestosUnaVez;
    // Start is called before the first frame update
    bool movimiento = false;
    public int cantidadDeBarriles;
    int contador;
    public GameObject barco;
    ListaChecks lista;
    public GameObject listaDeTareas;

    float timerRemado = 0;
    [SerializeField] float tiempoQueMueveUnRemado = 1;
    public float velocidad;

    public GameObject guardian;
    private void Awake()
    {
        lista = listaDeTareas.GetComponent<ListaChecks>();
    }
    private void FixedUpdate()
    {
        if(movimiento)
        {
            if(timerRemado > 0)
            {
                timerRemado -= Time.deltaTime;
                barco.transform.Translate(Vector3.back * (0.01f * velocidad));
            }
            
        }
    }

    public void Remado()
    {
        timerRemado = tiempoQueMueveUnRemado;
    }

    public void MovimientoFalse()
    {
        movimiento = false;
    }

    public void BarrilPuesto()
    {
        contador++;
        Debug.Log("holi");

        if(contador == cantidadDeBarriles) 
        {
            movimiento = true;
            if (!ambosPuestosUnaVez)
            {
                ambosPuestosUnaVez = true;
                //Ya puso lo barriles, se checkea la primera tarea
                lista.MisionCumplida();
                StartCoroutine(EsperarParaDesactivar(1));
            }
            
            
            
        }

    }

    IEnumerator  EsperarParaDesactivar(float segundos)
    {
        yield return new WaitForSeconds(segundos);
        CambiarEstadoDelGrabbableDeBarriles(false);
    }

    

    public void BarrilQuitado()
    {
        contador--;
    }

    public void CambiarEstadoDelGrabbableDeBarriles(bool estado)
    {
        GameObject[] barriles = GameObject.FindGameObjectsWithTag("Barriles");

        int puntos = estado == true? -1 : 0;
        

        foreach (GameObject barril in barriles)
        {
            barril.GetComponent<Grabbable>().MaxGrabPoints = puntos;
        }
    }

    public void ActivarBarrilesConFisicas()
    {
        GameObject[] barriles = GameObject.FindGameObjectsWithTag("Barriles");



        foreach (GameObject barril in barriles)
        {
            if (barril.GetComponent<ActivarBarrilConFisicas>())
            {
                barril.GetComponent<ActivarBarrilConFisicas>().ActivacionBarrilConFisicas();
            }
            
        }
    }

    public void AparecerGuardian()
    {
        guardian.GetComponent<Aparecer>().aparecer = true;
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    private void Start()
    {
        Invoke("Iniciar", 10f);
    }

    public void Iniciar()
    {
        SceneManager.LoadScene(1);
    }
}

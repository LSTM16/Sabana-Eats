using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlMenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Perfil()
    {
        SceneManager.LoadScene("Mi Perfil", LoadSceneMode.Single);
    }

    public void PuntosComida()
    {
        SceneManager.LoadScene("PuntosComida", LoadSceneMode.Single);
    }

    public void MiTurno()
    {
        
    }

    public void CarritoComparas()
    {
        
    }

    public void Soporte()
    {
        
    }

    public void Calificacion()
    {
        
    }
}

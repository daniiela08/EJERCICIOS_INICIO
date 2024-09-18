using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    void Start()
    {

        ConstruirNombre();
    }
    void ConstruirNombre(string nombre, string apellido, string apellido2 , int edad)
    {
        string saludo = "Te llamas " + nombre + " " + apellido + " " + apellido2 + " y tienes " + edad + " años");
    }

    
    void Update()
    {
        
    }
}

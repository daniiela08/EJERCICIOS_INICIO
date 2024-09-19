using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    void Start()
    {

        Debug.Log(ConstruirNombre("Daniela","Barroso","Ruiz",19));
    }
    string ConstruirNombre(string nombre, string apellido, string apellido2 , int edad)
    {
        string saludo = ("Te llamas " + nombre + " " + apellido + " " + apellido2 + " y tienes " + edad + " años");
        return saludo;
    }

    
    void Update()
    {
        
    }
}

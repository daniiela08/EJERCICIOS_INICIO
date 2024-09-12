using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_4 : MonoBehaviour
{
    string nombre = "Daniela";
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        Debug.Log("Este es el primer videojuego de" + nombre + " Y estoy aprendiendo C#");
    }

    void Update()
    {
        Debug.Log("Ha pasado un frame");
    }
}

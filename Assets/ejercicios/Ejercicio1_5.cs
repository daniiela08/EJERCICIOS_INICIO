using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_5 : MonoBehaviour
{
    //Se repite porque la función del Update esa ir repitiendolo todo el rato
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuaci�n1 = 30;
    int puntuaci�n2 = 50;
    int puntuaci�n3= 70;
    float media;
    void Start()
    {
        media = (puntuaci�n1 + puntuaci�n2 + puntuaci�n3) / 3;
        Debug.Log("La puntuaci�n 1 es: " + puntuaci�n1 + " lapuntuacion 2 es: " + puntuaci�n2 + " la puntuaci�n 3 es: " + puntuaci�n3 + " y su media es: "+ media);
    }

   
    void Update()
    {
        
    }
}

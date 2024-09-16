using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuación1 = 30;
    int puntuación2 = 50;
    int puntuación3= 70;
    float media;
    void Start()
    {
        media = (puntuación1 + puntuación2 + puntuación3) / 3;
        Debug.Log("La puntuación 1 es: " + puntuación1 + " lapuntuacion 2 es: " + puntuación2 + " la puntuación 3 es: " + puntuación3 + " y su media es: "+ media);
    }

   
    void Update()
    {
        
    }
}

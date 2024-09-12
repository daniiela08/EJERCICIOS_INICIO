using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float experiencia = 30.4f;
    char caracter = 'B';
    float resultsuma;
    float resultdiferencia;
    void Start()
    {
        Debug.Log(" Tengo de vidas :" + vidas+" y mi xp es :"+ experiencia);
        resultsuma = vidas + experiencia;
        resultdiferencia = experiencia - vidas;
        Debug.Log(" La suma de mis vidas con mi experiencia es: " + resultsuma + " La diferencia de mi experiencia con mis vidas es :" + resultdiferencia);
    }


    void Update()
    {
       
    }
}

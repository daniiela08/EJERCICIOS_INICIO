using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 2;
    float exp = 3.2f;
   float resultproducto;
    float resultcociente;
    float resto;
    float doblevidas;
    float triplex;
    void Start()
    {
        resultproducto = vidas * exp;
        resultcociente=vidas/exp;
        resto = vidas%exp;
        doblevidas = vidas * 2;
        triplex = exp * 3;
        Debug.Log("el resultado del producto es: " + resultproducto);
        Debug.Log("el resultado del cociente es: " + resultcociente);
        Debug.Log("el resultado del resto es: " + resto);
        Debug.Log("el doble de las vidas es: " + doblevidas);
        Debug.Log("el triple de la xp es: " + triplex);
    }

  
    void Update()
    {
        
    }
}

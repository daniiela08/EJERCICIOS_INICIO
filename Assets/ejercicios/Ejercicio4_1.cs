using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(" El area del circulo es:" + AreaCircle(3) + " ,el area del triangulo es:" + AreaTriangle(4, 2) + " ,y la del cuadrado es: " + AreaSquare(2));
    }
    float AreaCircle(float radiocircle)
    {
        float circulo = (radiocircle * radiocircle) * 3.14f;
        return circulo;
    }
    float AreaTriangle(float alturatriangle, float basetriangle)
    {
        float triangulo = (alturatriangle * basetriangle) / 2;
        return triangulo;
    } 
    float AreaSquare( float ladosquare)
    {
        float cuadrado = (ladosquare * ladosquare); 
        return cuadrado;
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 3;
    int incrementar;
    int descrementar;
    int cuadriplicar;
    void Start()
    {
        incrementar = vidas + 77;
        descrementar = incrementar - 3;
        cuadriplicar = descrementar * 4;
        Debug.Log(" Las vidas más el 77 es:" + incrementar + " La resta de su resultado es :" + descrementar + " Si ahora cuatriplico el resultado es: " + cuadriplicar);
    }

    void Update()
    {
        
    }
}

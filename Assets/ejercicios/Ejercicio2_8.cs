using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int puntos = 120;
    float tresp;
    float seisp;
    float nuevep;
    float docep;
    float quincep;
    void Start()
    {
        tresp = puntos - 3.6f;
        seisp = puntos - 7.2f;
        nuevep = puntos - 10.8f;
        docep = puntos - 14.4f;
        quincep = puntos - 18.0f;

        Debug.Log(" si me quitan el 3% me quedo con: " + tresp + " si me quitan el 6% me quedo con:" + seisp + " si me quitan el 9% me quedo con:" + nuevep + " si me quitan el 12% me quedo con:" + docep + " si me quitan el 15% me quedo con:" + quincep);

    }
    void Update()
    {
        
    }
}

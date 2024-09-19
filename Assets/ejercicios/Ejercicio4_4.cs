using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Conversor(50));
    }
    string Conversor(int Km)
    {
        string metroSeg = (Km + "km/h son " + (Km * 100) / 2 + " m/s");
        return metroSeg;
    }
    void Update()
    {
        
    }
}

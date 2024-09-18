using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float km;
    float metrosseg;
    void Start()
    {
        metrosseg = (km * 1000) / 3600;
        Debug.Log(km + " km/h son equivalentes a " + metrosseg + " m/s");
    }

    
    void Update()
    {
        
    }
}

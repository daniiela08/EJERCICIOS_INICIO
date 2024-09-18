using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float basetriangle;
    [SerializeField] float alturatriangle;

    float area;
    void Start()
    {
        area = (basetriangle * alturatriangle) / 2;
        Debug.Log(" El area de el trianulo con base" + basetriangle + " y altura" + alturatriangle + "es" + area);
    }

  
    void Update()
    {
        
    }
}

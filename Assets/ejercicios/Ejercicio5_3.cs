using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int num;
   
    void Start()
    {
        if(num > 0 && num <= 9)
        {
            Debug.Log("El numero esta entre 0 y 9");
        }
        else
        {
            Debug.Log("El numero no esta entre 0 y 9");
        }
    }

   
    void Update()
    {
        
    }
}

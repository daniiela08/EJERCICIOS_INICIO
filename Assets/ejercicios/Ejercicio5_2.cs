using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
   
    void Start()
    {
        if (num1 < num2 && num2 < 3)
        {
            Debug.Log("Los dos numeros son menores que 3");
        }
        else
        {
            Debug.Log("Los dos numeros no son menores que 3");
        }
    }

   
    void Update()
    {
        
    }
}

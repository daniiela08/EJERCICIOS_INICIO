using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1;
    [SerializeField] int vida2;
    
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("Las vidas son iguales");
        }
        else
        {
            Debug.Log("Las vidas no son iguales");
        }
    }

   
    void Update()
    {
        
    }
}

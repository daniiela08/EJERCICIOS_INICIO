using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        while (1 <= num1)
        {
            Debug.Log(num1);
                num1--;
        }
        for (int i = num2; i >=1; i--)
        {
            Debug.Log(i);
        }
    }

  
    void Update()
    {
        
    }
}

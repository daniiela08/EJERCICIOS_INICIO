using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        for (int i = num1; i < num2; i++)
        {
            Debug.Log(i % 2 == 0);
        }
    }
    void Update()
    {
        
    }
}

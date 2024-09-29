using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        while (-num1 <= num1)
        {
            Debug.Log(num1);
            num1--;
        }
        for (int i = num2; i >= -num2; i--)
        {
            Debug.Log(i);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    public int cont;
    void Start()
    {

        if (num1 < num2)
        {
            cont = num1;
            while (num1 < num2)
            {
                Debug.Log(num1);
                cont++;
            }
        }
        if (num2 < num1)
        {
            cont = num2;
            while (num2 < num1)
            {
                Debug.Log(num2);
                cont++;
            }
        }
        cont--;
    }
}

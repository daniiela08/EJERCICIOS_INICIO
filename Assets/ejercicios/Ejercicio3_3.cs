using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int num;

    int doble;
    int triple;
    void Start()
    {
        doble = num * 2;
        triple= num * 3;

        Debug.Log("El doble de tu número es:"+ doble + " y el triple es : " + triple);
    }


    void Update()
    {
        
    }
}

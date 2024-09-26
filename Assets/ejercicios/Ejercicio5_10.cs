using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int temperatura;
    void Start()
    {
        if(temperatura <=10)
        {
            Debug.Log("El personaje esta en clima frio");
        }
        else if(temperatura>10 && temperatura<=20)
        {
            Debug.Log("El personaje esta en clima nublado");
        }
        else if(temperatura>20 &&temperatura<=30)
        {
            Debug.Log("El personaje esta en clioma calido");    
        }
        else
        {
            Debug.Log("El personaje esta en clima tropical");
        }
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int lvl;
   
    void Start()
    {
        if( lvl %10== 0)
        {
            Debug.Log("Nuevo ataque");
        }  
    }

   
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
   
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("El enemigo  hace 350 de daño y tiene de vida 650");
        }
        else if(tipo == 2)
        {
            Debug.Log("El enemigo  hace 300 de daño y tiene de vida 550");
        }
        else if (tipo == 3)
        {
            Debug.Log("El enemigo  hace 300 de daño y tiene de vida 500");
        }
       else if (tipo == 4)
        {
            Debug.Log("El enemigo  hace 310 de daño y tiene de vida 460");
        }
        else if (tipo == 5)
        {
            Debug.Log("El enemigo  hace 280 de daño y tiene de vida 490");
        }
        else if (tipo == 6)
        {
            Debug.Log("El enemigo  hace 360 de daño y tiene de vida 520");
        }
        else 
        {
            Debug.Log("No es un tipo valido");
        }
    }

   
    void Update()
    {
        
    }
}

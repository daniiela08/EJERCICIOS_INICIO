using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int xp;

    int nivel;
    void Start()
    {
        nivel = 32 + (9 * xp / 5);
        Debug.Log("el nivel según la xp que has puesto es :" + nivel);
    }

   
    void Update()
    {
        
    }
}

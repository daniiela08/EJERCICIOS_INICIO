using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;

    float longitud;
    float area;
    void Start()
    {
        longitud = 2 * 3.14f * radio;
        area = 3.14f * (radio * radio);
        Debug.Log("LA LONGITUD ES :" + longitud + " Y SU AREA ES: " + area);

    }
    void Update()
    {
        
    }
}

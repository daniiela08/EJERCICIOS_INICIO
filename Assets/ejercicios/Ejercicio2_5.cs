using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 2;
    int vidasPlayer2 = 3;
    int vidasPlayer3 = 4;
    int vidasPlayer4 = 5;
    int vida2nueva;

    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer2;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vida2nueva;

        Debug.Log(" las vidas nuevas de player1 son:" + vidasPlayer1 + " las vidas nuevas del player2 son: " + vidasPlayer2 + " las nuevas vidas del player3 son: " + vidasPlayer3 + " las nuevas vidas del player 4 son: " + vida2nueva);
    }

    void Update()
    {
        
    }
}

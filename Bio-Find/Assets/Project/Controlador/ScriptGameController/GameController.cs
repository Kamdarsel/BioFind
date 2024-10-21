using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int Puntos;
    public TextMeshProUGUI puntosTXT;

    public void Sumarpuntos(int Suma)
    {
        Puntos += Suma;
        puntosTXT.text = Puntos.ToString();
    }

    
}

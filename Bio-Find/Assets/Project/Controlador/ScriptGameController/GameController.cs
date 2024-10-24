using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public int Puntos;
    public TextMeshProUGUI puntosTXT, incorrectosTXT, textoSecTXT;
    public string[] incorrectos;

    public void Sumarpuntos(int Suma)
    {
        Puntos += Suma;
        puntosTXT.text = Puntos.ToString();

        if (Puntos == 700)
        {
            textoSecTXT.text = "Felicidades, completaste correctamente BIOFIND";
        }
    }

    public void AgregarTexto(string Texto)
    {
        if (Puntos == 700)
        {
            textoSecTXT.text = "Felicidades, completaste correctamente BIOFIND";
        }else
        {
            textoSecTXT.text = "Fallaste en unas opciones... Fueron las siguientes:"; 
            incorrectosTXT.text += Texto;
        }
    }
}

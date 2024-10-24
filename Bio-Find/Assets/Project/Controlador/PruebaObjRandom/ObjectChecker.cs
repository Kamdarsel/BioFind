using UnityEngine;
using UnityEngine.UI;

public class ObjectChecker : MonoBehaviour
{
    // Referencias a los botones de "Está" y "No está" en la UI
    public Button buttonIsPresent;
    public Button buttonIsNotPresent;

    public int Points;  // Puntos obtenidos por la acción actual
    // El objeto que corresponde a esta entrada en la lista
    public GameObject associatedObject;

    // Referencia al controlador de puntos
    public GameController gc;

    void Start()
    {
        // Añadir listeners a los botones
        buttonIsPresent.onClick.AddListener(CheckIfObjectIsPresent);
        buttonIsNotPresent.onClick.AddListener(CheckIfObjectIsNotPresent);
    }

    void CheckIfObjectIsPresent()
    {
        // Verificar si el objeto está activo
        if (associatedObject.activeSelf)
        {
            Debug.Log("¡Correcto! El objeto está presente.");
            Points = 100;
        }
        else
        {
            Debug.Log("Incorrecto. El objeto no está presente.");
            Points = 0;
        }

        // Sumar o restar puntos
    }

    void CheckIfObjectIsNotPresent()
    {
        // Verificar si el objeto está inactivo
        if (!associatedObject.activeSelf)
        {
            Debug.Log("¡Correcto! El objeto no está presente.");
            Points = 100;
        }
        else
        {
            Debug.Log("Incorrecto. El objeto está presente.");
            Points = 0;
        }

        // Sumar o restar puntos
    }

    public void SumarpuntosT()
    {
        gc.Sumarpuntos(Points);  // Usar el valor de Points para sumar al GameController
        if(Points==0)
        {
            gc.AgregarTexto(associatedObject.name);
        }
    }
}

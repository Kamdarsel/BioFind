using UnityEngine;
using UnityEngine.UI;

public class ObjectChecker : MonoBehaviour
{
    // Referencias a los botones de "Está" y "No está" en la UI
    public Button buttonIsPresent;
    public Button buttonIsNotPresent;

    // El objeto que corresponde a esta entrada en la lista
    public GameObject associatedObject;

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
        }
        else
        {
            Debug.Log("Incorrecto. El objeto no está presente.");
        }
    }

    void CheckIfObjectIsNotPresent()
    {
        // Verificar si el objeto está inactivo
        if (!associatedObject.activeSelf)
        {
            Debug.Log("¡Correcto! El objeto no está presente.");
        }
        else
        {
            Debug.Log("Incorrecto. El objeto está presente.");
        }
    }
}

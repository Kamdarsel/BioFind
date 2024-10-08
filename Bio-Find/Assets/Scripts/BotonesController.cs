using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesController : MonoBehaviour
{
    public Button cumpleButton;
    public Button noCumpleButton;

    private bool cumpleSelected = false;
    private bool noCumpleSelected = false;

    private Color cumpleTextColor = Color.green;  // Color básico para "Cumple"
    private Color noCumpleTextColor = Color.red;  // Color básico para "No Cumple"
    private Color selectedTextColor = Color.white;  // Color del texto cuando está seleccionado

    void Start()
    {
        // Asignar listeners a los botones
        cumpleButton.onClick.AddListener(() => ToggleCumpleButton());
        noCumpleButton.onClick.AddListener(() => ToggleNoCumpleButton());

        // Inicializar el estado de los botones
        UpdateButtonVisuals();
    }

    void ToggleCumpleButton()
    {
        cumpleSelected = !cumpleSelected;
        noCumpleSelected = false;  // Solo uno puede estar seleccionado a la vez
        UpdateButtonVisuals();
    }

    void ToggleNoCumpleButton()
    {
        noCumpleSelected = !noCumpleSelected;
        cumpleSelected = false;  // Solo uno puede estar seleccionado a la vez
        UpdateButtonVisuals();
    }

    void UpdateButtonVisuals()
    {
        // Si "Cumple" está seleccionado, texto blanco y fondo verde, y desactivar el botón
        if (cumpleSelected)
        {
            cumpleButton.GetComponentInChildren<Text>().color = selectedTextColor;
            cumpleButton.GetComponent<Image>().color = Color.green;
            cumpleButton.interactable = false;  // Desactiva el botón "Cumple"
        }
        else
        {
            cumpleButton.GetComponentInChildren<Text>().color = cumpleTextColor;
            cumpleButton.GetComponent<Image>().color = Color.white;  // Fondo blanco cuando no está seleccionado
            cumpleButton.interactable = true;  // Reactiva el botón "Cumple"
        }

        // Si "No Cumple" está seleccionado, texto blanco y fondo rojo, y desactivar el botón
        if (noCumpleSelected)
        {
            noCumpleButton.GetComponentInChildren<Text>().color = selectedTextColor;
            noCumpleButton.GetComponent<Image>().color = Color.red;
            noCumpleButton.interactable = false;  // Desactiva el botón "No Cumple"
        }
        else
        {
            noCumpleButton.GetComponentInChildren<Text>().color = noCumpleTextColor;
            noCumpleButton.GetComponent<Image>().color = Color.white;  // Fondo blanco cuando no está seleccionado
            noCumpleButton.interactable = true;  // Reactiva el botón "No Cumple"
        }
    }
}

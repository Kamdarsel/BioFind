using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR; // Asegúrate de importar el espacio de nombres XR

public class CanvaPause : MonoBehaviour
{
    public GameObject CanvaPausa;
    private bool Cambio;

    void Update()
    {
        // Obtener el estado de los dispositivos XR
        InputDevice leftController = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);

        // Verifica si el controlador izquierdo está conectado
        if (leftController.isValid)
        {
            // Verifica si el botón izquierdo (Primary Button) está presionado
            if (leftController.TryGetFeatureValue(CommonUsages.primaryButton, out bool isPressed) && isPressed)
            {
                // Cambia el estado del Canvas solo si se presiona el botón
                Cambio = !Cambio;
                CanvaPausa.SetActive(Cambio);
            }
        }
    }
}
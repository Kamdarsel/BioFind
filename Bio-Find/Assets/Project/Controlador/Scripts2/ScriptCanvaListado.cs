using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCanvaListado : MonoBehaviour
{
    public GameObject CanvaListado;

    bool Cambio;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Cambio=!Cambio;
            CanvaListado.SetActive(Cambio);
        }   
    }
}

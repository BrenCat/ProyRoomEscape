using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDown : MonoBehaviour
{
    public void Pulsar()
    {
        if (Input.GetMouseButton(0)) 
        {
            Debug.Log("CLICKEADO");

        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Herramienta : MonoBehaviour
{
    public Collider2D collider2;
    public Collider2D colSlot;
    public enum tipoDeHerramienta { martillo, llaveTrofeo, maletin, llaveEntrada }
    public tipoDeHerramienta tipo;

    //variable de otra clase, de tipo sprite
    [SerializeField] Image imagenHerramienta;
    //variablre de otra clase, de tipo textMeshPro
    [SerializeField] TextMeshProUGUI nombreHerramienta;


    public void CrearHerramienta(HerramientaScrpObj datosHerramienta)
    {
        imagenHerramienta.sprite = datosHerramienta.imagenHerramienta;
        nombreHerramienta.text = datosHerramienta.nombreHerramienta;
    }
    /*
    public void TocoInventario() 
    {
        if (collider2.IsTouching(colSlot)) 
        {
            Debug.Log("toco inventario");
        }
    }
    */

    private void Update()
    {
        
    }
}

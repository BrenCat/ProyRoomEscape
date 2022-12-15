using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventarioJugador : MonoBehaviour
{

    //declaración lista
    public List<HerramientaScrpObj> herramientas = new List<HerramientaScrpObj>();
    // public GameObject invObj;

    public GameObject imagen;

    public Image imaSlot;

    //bool estaLleno = false;

    public static InventarioJugador instancia;

    [SerializeField] Image imagenHerramienta;
    [SerializeReference] [HideInInspector] Herramienta tipo;

    //[SerializeField] [HideInInspector] Collider2D colliderPan;
    private void Awake()
    {
        instancia = this;
    }

    private void Start()
    {
        imaSlot.GetComponent<Image>();
        imaSlot.gameObject.SetActive(false);
    }

    /* public void OnTriggerEnter2D(Collider2D collider)
     {
         Debug.Log("ha colisionado CON");

         if (collider.tag == "herramienta")
         {
             Debug.Log("condición cumplida el inv colisiona con tag herramienta");
             AgregarHerramientaSlot();
         }
     }*/

    public void AgregarHerramientaSlot()
    {
        Debug.Log("tocaste " + gameObject);
        //imaSlot = imagenHerramienta.GetComponent<Image>();
        //imaSlot = imagen.GetComponent<Image>();
        imaSlot.gameObject.SetActive(true);
            //estaLleno = true;
            /*
                       if (tipo == tipoDeHerramienta.martillo) 
                       {
                           imaSlot = imagenHerramienta.GetComponent<Image>();
                           imaSlot.gameObject.SetActive(true);

                           if (imaSlot.gameObject == true)
                           {
                               estaLleno = true;
                           }

                       }
                       if (tipo == tipoDeHerramienta.llaveTrofeo)
                       {
                           imaSlot = imagenHerramienta.GetComponent<Image>();
                           imaSlot.gameObject.SetActive(true);
                       }
                       //Destroy(gameObject);
                       //Instantiate(particle, transform.position, Quaternion.identity);
                   } 
                   else 
                   {
                    Debug.Log("El espacio ya esta ocupado");
                   }*

                 */
        
    }

    private void Update()
    {
       // AgregarHerramientaSlot();
    }
}

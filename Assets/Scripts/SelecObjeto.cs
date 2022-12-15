using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SelecObjeto : MonoBehaviour
{
    public static SelecObjeto instancia;

    public GameObject selectedObject1;
    public GameObject selectedObject2;
    public GameObject selectedObject3;
    public GameObject selectedObject4;

    Collider2D colliderPan;
   // Collider2D otroCollider;
    Camera cam;
    bool estaSiendoArrastrado = false;

    void Start()
    {
        GameObject selectedObject1 = new GameObject();
        selectedObject1.transform.position = new Vector2(102, 465);

        GameObject selectedObject2 = new GameObject();
        selectedObject2.transform.position = new Vector2(305, 360);

        GameObject selectedObject3 = new GameObject();
        selectedObject3.transform.position = new Vector2(720, 445);

        GameObject selectedObject4 = new GameObject();
        selectedObject4.transform.position = new Vector2(720, 300);

        colliderPan = GetComponent<Collider2D>();
        cam = Camera.main;

    }

    void Update()
    {
       bool tocaCollider = false;

        // vector que da la posicion del mouse, la camara lo pasa de la pantalla al punto donde esta posicionado el puntero. 
        Vector2 posMouse = cam.ScreenToWorldPoint(Input.mousePosition);
        
        if (colliderPan.IsTouching(gameObject.GetComponent<Collider2D>())) 
        {
            Debug.Log("isTouching true");
            tocaCollider = true;
        }
        if (tocaCollider == true)
        {
            colliderPan.isTrigger = true;
            Debug.Log("esta tocando otro colisionador");
        }
        else
        { tocaCollider = false; }

        //si el boton izq del mouse es presionado
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //Collider que utiliza las "físicas 2D" y checa si el puntero esta encima del collider del objeto.  
            Collider2D collider = Physics2D.OverlapPoint(posMouse);

            //Si el collider es igual al colliderPan 
            if (collider == colliderPan)
            {
                estaSiendoArrastrado = true;
            }
            //si el objeto esta siendo arrastrado 
            if (estaSiendoArrastrado == true)
            {   //la posición del ColliderPan será igual a la posición del mouse. 
                colliderPan.transform.position = posMouse;
            }
        }
        else // Si no, la condicion se vuelve falsa
        { 
            estaSiendoArrastrado = false; 
        }

        /* if (Input.GetKey(KeyCode.Mouse0))
         {
             Debug.Log("Click Izq");
         }*/
        // si el click izq es presionado y la etiqueta del objeto es "herramienta"
        /* if (Input.GetKey(KeyCode.Mouse0) && gameObject.CompareTag("herramienta"))
         {
             Debug.Log("Esta siendo clickeado herramienta" + transform.position);
             //posicion del puntero de la pantalla al mundo
             RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
             Vector2 movPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

             Collider2D targetObject = Physics2D.OverlapPoint(movPosition);

             if (targetObject)
             {
                 selectedObject1 = targetObject.transform.gameObject;
             }
        /*
        if (gameObject.CompareTag("herramienta") == selectedObject1 || selectedObject2 || selectedObject3 || selectedObject4)
        { 
            if (Input.GetMouseButtonUp(0) && selectedObject1)
            {
                selectedObject1 = null;
            }

            if (Input.GetMouseButtonUp(0) && selectedObject1)
            {
                selectedObject2 = null;
            }

            if (Input.GetMouseButtonUp(0) && selectedObject1)
            {
                selectedObject3 = null;
            }

            if (Input.GetMouseButtonUp(0) && selectedObject1)
            {
                selectedObject4 = null;
            }

        }
        */
        //}


    }


        /* RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

         if (hit.collider != null)
         {
             Debug.Log("Target name: " + hit.collider.name);
         }*/

        /*
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
            }
        }*/
    


    

}

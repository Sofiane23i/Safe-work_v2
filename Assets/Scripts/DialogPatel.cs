using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogPatel : MonoBehaviour
{

    public GameObject CanvasPatel;
    static public bool enableInteraction3 = false;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {
        if(enableInteraction3 == false)
        {
        Debug.Log("Bonjour");
        //GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
        CanvasPatel.gameObject.SetActive(true);
        enableInteraction3 = true;
        }
        
    } 
    

    void OnMouseEnter(){
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit(){
        //Cursor.SetCursor(cursorArrowDefault, Vector2.zero, CursorMode.ForceSoftware);
    }

    
}

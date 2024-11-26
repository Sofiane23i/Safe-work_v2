using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogChris1 : MonoBehaviour
{

    public GameObject CanvasChris1;
    static public bool enableInteraction = false;
   
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {
        if(enableInteraction == false)
        {
        Debug.Log("Bonjour");
        //GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
        CanvasChris1.gameObject.SetActive(true);
        enableInteraction = true;
        }
        
        
        
    } 
    

    void OnMouseEnter(){
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit(){
        //Cursor.SetCursor(cursorArrowDefault, Vector2.zero, CursorMode.ForceSoftware);
    }

    
}

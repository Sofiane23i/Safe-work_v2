using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogChris3 : MonoBehaviour
{

    public GameObject CanvasChris2;
  
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {
        if(DialogPatel.enableInteraction3 == false)
        {
        Debug.Log("Bonjour");
        //GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
        CanvasChris2.gameObject.SetActive(true);
        DialogPatel.enableInteraction3 = true;
        }
        
    } 
    

    void OnMouseEnter(){
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit(){
        //Cursor.SetCursor(cursorArrowDefault, Vector2.zero, CursorMode.ForceSoftware);
    }

    
}

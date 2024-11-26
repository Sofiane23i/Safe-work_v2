using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogSemaineCalendrier : MonoBehaviour
{
    

    // Start is called before the first frame update
    public GameObject CanvasSemaineCalendrier;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {
        if(DialogChris1.enableInteraction == false)
        {
        Debug.Log("Bonjour");
        //GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
        CanvasSemaineCalendrier.SetActive(true);
        DialogChris1.enableInteraction = true;

        }
        
    } 
    

    void OnMouseEnter(){
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit(){
        //Cursor.SetCursor(cursorArrowDefault, Vector2.zero, CursorMode.ForceSoftware);
    }

    
}

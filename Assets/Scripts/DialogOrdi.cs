using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogOrdi : MonoBehaviour
{
    
    public Texture2D cursorArrow;
    public Texture2D cursorArrowDefault;
    // Start is called before the first frame update
    public GameObject CanvasOrdiChris;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {
        Debug.Log("Bonjour");
        //GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
        CanvasOrdiChris.SetActive(true);
        
    } 
    

    void OnMouseEnter(){
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit(){
        //Cursor.SetCursor(cursorArrowDefault, Vector2.zero, CursorMode.ForceSoftware);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DialogueEditor;

public class DialogLeonard : MonoBehaviour
{
    [SerializeField] private NPCConversation conversation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {
        ConversationManager.Instance.StartConversation(conversation);
        
    } 
    

    void OnMouseEnter(){
        //Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit(){
        //Cursor.SetCursor(cursorArrowDefault, Vector2.zero, CursorMode.ForceSoftware);
    }

    
}

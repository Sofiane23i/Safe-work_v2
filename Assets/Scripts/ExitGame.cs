
using UnityEngine;



public class ExitGame : MonoBehaviour
{


    void Update()
    {

    }


    

    public void GameExit()
    {
        #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }



}

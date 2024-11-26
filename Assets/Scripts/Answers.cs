using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Answers : MonoBehaviour
{
    
    public bool isCorrect = false;
    public QuizManager quizManager;
    // Start is called before the first frame update
    public Color startColor;

    private void Start()
    {
        startColor = GetComponent<UnityEngine.UI.Image>().color;
    }
    public void Answer()
    {
        if(isCorrect)
        {
            GetComponent<UnityEngine.UI.Image>().color = Color.green;
            Debug.Log("Correct");
            quizManager.Correct();
        }
        else
        {
            GetComponent<UnityEngine.UI.Image>().color = Color.red;
            Debug.Log("Incorrect");
            quizManager.Correct();
        }
        
    }

  
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class QuizManager : MonoBehaviour
{
    public List<QA> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public TMP_Text QuestionTxt;
    public Sprite Spriteq1;
    public Sprite Spriteq2;
    public Sprite Spriteq3;
    public Image ImgQz;
    public TMP_Text Score;

    public GameObject canvasQZ;
    public GameObject canvasAccueil;

    public GameObject CanvasStart;

    static private Camera cameraSalle1;
    

    
    // Start is called before the first frame update
    private void Start()
    {
        generateQuestion();
        ImgQz.sprite = Spriteq1;
    }

    public void Correct()
    {
        QnA.RemoveAt(currentQuestion);
        Debug.Log(QnA.Count);

        if (QnA.Count >0)
        {       
            generateQuestion();           

            ImgQz.sprite = Spriteq2;

            Score.text = "10/ 20";
        }else
        {
            Debug.Log("Stage terminé");

            canvasQZ.SetActive(false);
            canvasAccueil.SetActive(false);

            CanvasStart.SetActive(true);

            cameraSalle1 = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
            Camera.main.transform.position = new UnityEngine.Vector3(-53, -70, 325);
            Camera.main.transform.rotation = Quaternion.Euler(42f, 75f, 0f);

            TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
            script.enabled = false;

            
            
        
        }
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }

    }
    void generateQuestion()
    {
        currentQuestion = 0; //UnityEngine.Random.Range(0, 1); //QnA.Count);
        //Debug.Log(currentQuestion);

        QuestionTxt.text = QnA[currentQuestion].Question;

        SetAnswers();

        

        //QnA.RemoveAt(currentQuestion);
    }


}

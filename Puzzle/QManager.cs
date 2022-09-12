using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QManager : MonoBehaviour
{
    private int correctAnswerIndex;
    public GameObject correctPanel, wrongPanel;

    public Question[] questions; // Questions'lara eriþtik.

    // text'lere eriþmek
    
    public Text questionText;
    public Text[] buttonText;

    //Hangi Sorudayýz
    //   private int currentQuestion=0;
    private int currentQuestion = 0;


    private void Start()
    {
        SetQuestion();
    }
    private void SetQuestion()
    {
        int questionIndex = currentQuestion % questions.Length;
        questionText.text = questions[questionIndex].questionText;

        for(int i=0; i<buttonText.Length; i++)
        {
            buttonText[i].text = questions[questionIndex].answers[i];
            correctAnswerIndex = questions[questionIndex].correctAnswerIndex;
            currentQuestion++;
        }
    }
    public void AnswerButton(int answerIndex)
    {
        if (answerIndex == correctAnswerIndex)
        {
            correctPanel.gameObject.SetActive(true);
        }
        else
        {
            wrongPanel.gameObject.SetActive(true);
        }
    }
    public void PanelButton(bool isTrue)
    {
        if (isTrue)
        {
            correctPanel.gameObject.SetActive(false);
            SetQuestion();
        }

        else
        {
            wrongPanel.gameObject.SetActive(false);
        }

    }
}

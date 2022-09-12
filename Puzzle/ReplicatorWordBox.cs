using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ReplicatorWordBox : MonoBehaviour
{
    


    [HideInInspector]
    public List<Questions> questionsList;
    public Questions nowQuestions;

    public GameObject SlotObje;
    public Text questionText;
    public InputField questionField;
    public Text clearText;


    int randomQuestion;
    
    private void Awake()
    {
        ComeQuestion();
    }

   private  void ComeQuestion()
    {
        foreach (Transform obje in this.transform)
            {
                Destroy(obje.gameObject);
            }
        randomQuestion = Random.Range(0, questionsList.Count);
        nowQuestions.Question = questionsList[randomQuestion].Question;
        nowQuestions.Answer = questionsList[randomQuestion].Answer;

        for (int i = 0; i< nowQuestions.Answer.Length;i++)
        {
           
            GameObject reflactor = Instantiate(SlotObje,transform);
            reflactor.transform.Find("SlotText").GetComponent<Text>().text = nowQuestions.Answer[i].ToString();

            
            questionsList[randomQuestion].OffWord.Add(reflactor.transform.Find("SlotText").GetComponent<Text>());
            questionText.text = nowQuestions.Question;
            reflactor.transform.Find("SlotText").gameObject.SetActive(false);

        }
        nowQuestions.OffWord = questionsList[randomQuestion].OffWord;
    }

    public void BuyWord()
    {if(nowQuestions.OffWord.Count  >0)
        {
            int randomWord = Random.Range(0, nowQuestions.OffWord.Count);
            nowQuestions.OffWord[randomWord].gameObject.SetActive(true);
            nowQuestions.OffWord.RemoveAt(randomWord);
        }else
        {
            questionsList.RemoveAt(randomQuestion);
            Debug.Log("Kazandýnýz");
            Invoke("ComeQuestion", 3f);
           

        }
        

    }

    public void CorrectButton()
    {
       
        
           
        
        if (questionField.text == nowQuestions.Answer || questionField.text.ToLower() == nowQuestions.Answer.ToLower())
        {
            Debug.Log("Kazandýnýz");
            Destroy(clearText);
            clearText.gameObject.SetActive(true);
            questionsList.RemoveAt(randomQuestion);
            
            
            
            foreach ( Text texts in nowQuestions.OffWord)
            {
                texts.gameObject.SetActive(true);
            }
            Invoke("ComeQuestion", 4f);
            Destroy(clearText);
            clearText.gameObject.SetActive(true);


        }
        else
        {
            Debug.Log("Yanlýþ Tahmin");
        }
    }

}

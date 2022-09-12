using System.Collections.Generic;
using UnityEngine.UI;

[System.Serializable]
public class Questions
{
    public string Question;
    public string Answer;
    public List<Text> OffWord;

    public Questions(string question, string answer, List<Text> offWord)
    {
        Question = question;
        Answer = answer;
        OffWord = offWord;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestFunctions : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private TextMeshProUGUI textResult;

    [SerializeField] private int NumberOfRepetitions;
    // Start is called before the first frame update
    void Start()
    {
        ChangeText();

        textResult.text = "The textbox contains the text: " + GetTheText();

        textResult.text += RepeatText(NumberOfRepetitions);
    }

    private void ChangeText()
    {
        textMeshProUGUI.text += " fields";
    }

    private string GetTheText()
    {
        return textMeshProUGUI.text;
    }

    private string RepeatText(int repetitions)
    {
        string result = "";
        
        for (int i = 0; i < repetitions; i++)
        {
            result += "\n" + GetTheText() + ";" + i ;
        }

        return result;

    }

    public void DuplicateText()
    {
        textMeshProUGUI.text += "\n" + GetTheText();
    }

}

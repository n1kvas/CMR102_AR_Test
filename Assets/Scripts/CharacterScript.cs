using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterScript : MonoBehaviour
{
    [SerializeField] string definedName = "Fox";

    [SerializeField]  bool autoGenerateNewName = false;

    [SerializeField]  GameObject nameTagObj;

    [SerializeField]  string[] namesArray;
    [SerializeField]  List<string> namesList;

    // Start is called before the first frame update
    void Start()
    {
        if(autoGenerateNewName)
        {
            //run a small little function to make a new name
            //accessing the component, then grabbing the text box, and putting our result into there
            //nameTagObj.GetComponent<TextMesh>().text = RandomStringGenerator(8);
            //pick a random name from our array
            string name = namesArray[Random.Range(0, namesArray.Length)];
            nameTagObj.GetComponent<TextMeshProUGUI>().text = name;
        }
        else
        {
            nameTagObj.GetComponent<TextMeshProUGUI>().text = definedName;
        }
    }

    public string RandomStringGenerator(int length)
    {
        string result = "";
        //loop through this code, number of times is equal to length
        for(int i = 0; i < length; i++)
        {
            //store a temporary value of a new char, (char) turns the random.range number into a char
            char c = (char)('A' + Random.Range(0, 26));
            //add that char to our string, so e.g. "AlKn..."
            result += c;
        }
        //send that back to where we called this function
        return result;
    }

}
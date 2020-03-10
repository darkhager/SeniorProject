using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSystem : MonoBehaviour
{
    string alphabetSet = "";
    string[] alphabetCollection = {
        "a", "a", "a", "a", "a", "a", "a", "a", "a",//9
        "b", "b",//2
        "c", "c",//2
        "d", "d", "d", "d",//4
        "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e",//12
        "f", "f",//2
        "g", "g", "g",//3
        "h", "h",//2
        "i", "i", "i", "i", "i", "i", "i", "i", "i",//9
        "j",//1
        "k",//1
        "l", "l", "l", "l",//4
        "m", "m",//2
        "n", "n", "n", "n", "n", "n",//6
        "o", "o", "o", "o", "o", "o", "o", "o",//8
        "p", "p",//2
        "q",//1
        "r", "r", "r", "r", "r", "r",//6
        "s", "s", "s", "s",//4
        "t", "t", "t", "t", "t", "t",//6
        "u", "u", "u", "u",//4
        "v", "v",//2
        "w", "w",//2
        "x",//1
        "y", "y",//2
        "z" };//1
    public Text alphaText, alphabet1, alphabet2,alphabet3, alphabet4, alphabet5, 
        alphabet6, alphabet7, alphabet8, alphabet9, alphabet10, 
        alphabet11, alphabet12, alphabet13, alphabet14, alphabet15
        ;

    void Start()
    {
        while (alphabetSet.Length != 15) {
            alphabetSet = alphabetSet + alphabetCollection[UnityEngine.Random.RandomRange(0,alphabetCollection.Length)];
        }
        int count = 0;
        for (int i = 0; i < 15; i++) {
            if (alphabetSet[i] == 'a' || alphabetSet[i] == 'e' || alphabetSet[i] == 'i' || alphabetSet[i] == 'o' || alphabetSet[i] == 'u') { }
        }
            alphaText.text = alphabetSet;
            alphabet1.text = new string(alphabetSet[0], 1);
            alphabet2.text = new string(alphabetSet[1], 1);
            alphabet3.text = new string(alphabetSet[2], 1);
            alphabet4.text = new string(alphabetSet[3], 1);
            alphabet5.text = new string(alphabetSet[4], 1);
            alphabet6.text = new string(alphabetSet[5], 1);
            alphabet7.text = new string(alphabetSet[6], 1);
            alphabet8.text = new string(alphabetSet[7], 1);
            alphabet9.text = new string(alphabetSet[8], 1);
            alphabet10.text = new string(alphabetSet[9], 1);
            alphabet11.text = new string(alphabetSet[10], 1);
            alphabet12.text = new string(alphabetSet[11], 1);
            alphabet13.text = new string(alphabetSet[12], 1);
            alphabet14.text = new string(alphabetSet[13], 1);
            alphabet15.text = new string(alphabetSet[14], 1);
    }


    void Update()
    {
        while (alphabetSet.Length != 15)
        {
            alphabetSet = alphabetSet + alphabetCollection[UnityEngine.Random.RandomRange(0, alphabetCollection.Length)]; 
        }
            alphaText.text = alphabetSet;
            alphabet1.text = new string(alphabetSet[0], 1);
            alphabet2.text = new string(alphabetSet[1], 1); 
            alphabet3.text = new string(alphabetSet[2], 1); 
            alphabet4.text = new string(alphabetSet[3], 1); 
            alphabet5.text = new string(alphabetSet[4], 1); 
            alphabet6.text = new string(alphabetSet[5], 1); 
            alphabet7.text = new string(alphabetSet[6], 1); 
            alphabet8.text = new string(alphabetSet[7], 1); 
            alphabet9.text = new string(alphabetSet[8], 1); 
            alphabet10.text = new string(alphabetSet[9], 1); 
            alphabet11.text = new string(alphabetSet[10], 1); 
            alphabet12.text = new string(alphabetSet[11], 1);
            alphabet13.text = new string(alphabetSet[12], 1);
            alphabet14.text = new string(alphabetSet[13], 1);
            alphabet15.text = new string(alphabetSet[14], 1);
    }
}

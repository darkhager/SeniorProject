using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSystem : MonoBehaviour
{
    string alphabetSet = "";
    string[] alphabetCollection = {
        "A", "A", "A", "A", "A", "A", "A", "A", "A",//9
        "B", "B",//2
        "C", "C",//2
        "D", "D", "D", "D",//4
        "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E",//12
        "F", "F",//2
        "G", "G", "G",//3
        "H", "H",//2
        "I", "I", "I", "I", "I", "I", "I", "I", "I",//9
        "J",//1
        "K",//1
        "L", "L", "L", "L",//4
        "M", "M",//2
        "N", "N", "N", "N", "N", "N",//6
        "O", "O", "O", "O", "O", "O", "O", "O",//8
        "P", "P",//2
        "Q",//1
        "R", "R", "R", "R", "R", "R",//6
        "S", "S", "S", "S",//4
        "T", "T", "T", "T", "T", "T",//6
        "U", "U", "U", "U",//4
        "V", "V",//2
        "W", "W",//2
        "X",//1
        "Y", "Y",//2
        "Z" };//1
    string[] vowelCollection = {
        "A", "A", "A", "A", "A", "A", "A", "A", "A",
        "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E",
        "I", "I", "I", "I", "I", "I", "I", "I", "I",
        "O", "O", "O", "O", "O", "O", "O", "O",
        "U", "U", "U", "U"
    };
    public Text alphaText, alphabet1, alphabet2,alphabet3, alphabet4, alphabet5, 
        alphabet6, alphabet7, alphabet8, alphabet9, alphabet10, 
        alphabet11, alphabet12, alphabet13, alphabet14, alphabet15
        ;

    void Start()
    {
        while (alphabetSet.Length != 11)
        {
            alphabetSet = alphabetSet + alphabetCollection[UnityEngine.Random.RandomRange(0, alphabetCollection.Length)];
        }
        int count = 0;
        for (int i = 0; i < 11; i++)
        {
            if (alphabetSet[i] == 'A' || alphabetSet[i] == 'E' || alphabetSet[i] == 'I' || alphabetSet[i] == 'O' || alphabetSet[i] == 'U')
            {
                count++;
            }
        }
        if (count < 4) {
            for (int i = 0; i < 4-count; i++)
            {
                alphabetSet = alphabetSet + vowelCollection[UnityEngine.Random.RandomRange(0, vowelCollection.Length)];
            }
        }
        for (int i = alphabetSet.Length; i < 15; i++)
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


    void Update()
    {
        while (alphabetSet.Length != 11)
        {
            alphabetSet = alphabetSet + alphabetCollection[UnityEngine.Random.RandomRange(0, alphabetCollection.Length)];
        }
        int count = 0;
        for (int i = 0; i < 11; i++)
        {
            if (alphabetSet[i] == 'A' || alphabetSet[i] == 'E' || alphabetSet[i] == 'I' || alphabetSet[i] == 'O' || alphabetSet[i] == 'U')
            {
                count++;
            }
        }
        if (count < 4)
        {
            for (int i = 0; i < 4 - count; i++)
            {
                alphabetSet = alphabetSet + vowelCollection[UnityEngine.Random.RandomRange(0, vowelCollection.Length)];
            }
        }
        for (int i = alphabetSet.Length; i < 15; i++)
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

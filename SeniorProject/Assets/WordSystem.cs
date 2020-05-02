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
        "Z"//1 
};
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
        while(alphabetSet.Length!=15){
            alphabetSet = alphabetSet+alphabetCollection[Random.Range(0,alphabetCollection.Length-1)];
        }
    }


    void Update()
    {
        alphaText.text = alphabetSet;
        alphabet1.text = alphabetSet.Substring(0,1);
        alphabet2.text = alphabetSet.Substring(1, 1);
        alphabet3.text = alphabetSet.Substring(2, 1);
        alphabet4.text = alphabetSet.Substring(3, 1);
        alphabet5.text = alphabetSet.Substring(4, 1);
        alphabet6.text = alphabetSet.Substring(5, 1);
        alphabet7.text = alphabetSet.Substring(6, 1);
        alphabet8.text = alphabetSet.Substring(7, 1);
        alphabet9.text = alphabetSet.Substring(8, 1);
        alphabet10.text = alphabetSet.Substring(9, 1);
        alphabet11.text = alphabetSet.Substring(10, 1);
        alphabet12.text = alphabetSet.Substring(11, 1);
        alphabet13.text = alphabetSet.Substring(12, 1);
        alphabet14.text = alphabetSet.Substring(13, 1);
        alphabet15.text = alphabetSet.Substring(14, 1);
        string[] arrayCheck= { };
        int count = 0;
        for (int i = 0; i < 15; i++) {
            if (alphabetSet[i] == 'A') {
                arrayCheck[i] ="A";
                count++;
            }
            if (alphabetSet[i] == 'E')
            {
                arrayCheck[i] = "E";
                count++;
            }
            if (alphabetSet[i] == 'I')
            {
                arrayCheck[i] = "I";
                count++;
            }
            if (alphabetSet[i] == 'O')
            {
                arrayCheck[i] = "O";
                count++;
            }
            if (alphabetSet[i] == 'U')
            {
                arrayCheck[i] = "U";
                count++;
            }
        }
        if (count < 4) {
            
        }
    }
}

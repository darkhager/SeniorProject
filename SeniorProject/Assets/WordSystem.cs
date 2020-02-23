using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSystem : MonoBehaviour
{
    Random rand = new Random();
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
    public Text alphaText;

    void Start()
    {
        while (alphabetSet.Length != 16) {
            alphabetSet = alphabetSet + alphabetCollection[UnityEngine.Random.RandomRange(0,alphabetCollection.Length)];
            alphaText.text = alphabetSet;
        }
    }


    void Update()
    {
        while (alphabetSet.Length != 16)
        {
            alphabetSet = alphabetSet + alphabetCollection[UnityEngine.Random.RandomRange(0, alphabetCollection.Length)];
            alphaText.text = alphabetSet;
        }
    }
}

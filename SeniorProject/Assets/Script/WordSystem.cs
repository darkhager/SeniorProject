using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSystem : MonoBehaviour
{
    string alphabetSet = "", wordString="", dictionary;
    string[] alphabetSetCollection = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
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
        alphabet11, alphabet12, alphabet13, alphabet14, alphabet15,
        word, score, alphabetScore1, alphabetScore2, alphabetScore3, alphabetScore4
        , alphabetScore5, alphabetScore6, alphabetScore7, alphabetScore8
        , alphabetScore9, alphabetScore10, alphabetScore11, alphabetScore12
        , alphabetScore13, alphabetScore14, alphabetScore15;
    public Button button1, button2, button3, button4, button5, button6, button7, button8,
        button9, button10, button11, button12, button13, button14, button15,
        refresh, check;
    public TextAsset dictionaryFile;
    private int[] scoreControl = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    void Start()
    {
        score.text = "Score : 0";
        dictionary = dictionaryFile.text;
        refresh.interactable = false;
        check.interactable = false;
        AlphabetSetRandom();
        AlphaScore();
    }


    void Update()
    {
        
        alphaText.text = alphabetSet;
   
        alphabet1.text = alphabetSetCollection[1];
        alphabet2.text = alphabetSetCollection[2];
        alphabet3.text = alphabetSetCollection[3];
        alphabet4.text = alphabetSetCollection[4];
        alphabet5.text = alphabetSetCollection[5];
        alphabet6.text = alphabetSetCollection[6];
        alphabet7.text = alphabetSetCollection[7];
        alphabet8.text = alphabetSetCollection[8];
        alphabet9.text = alphabetSetCollection[9];
        alphabet10.text = alphabetSetCollection[10];
        alphabet11.text = alphabetSetCollection[11];
        alphabet12.text = alphabetSetCollection[12];
        alphabet13.text = alphabetSetCollection[13];
        alphabet14.text = alphabetSetCollection[14];
        alphabet15.text = alphabetSetCollection[15];

        alphabetScore1.text = ""+ scoreControl[1];
        alphabetScore2.text = "" + scoreControl[2];
        alphabetScore3.text = "" + scoreControl[3];
        alphabetScore4.text = "" + scoreControl[4];
        alphabetScore5.text = "" + scoreControl[5];
        alphabetScore6.text = "" + scoreControl[6];
        alphabetScore7.text = "" + scoreControl[7];
        alphabetScore8.text = "" + scoreControl[8];
        alphabetScore9.text = "" + scoreControl[9];
        alphabetScore10.text = "" + scoreControl[10];
        alphabetScore11.text = "" + scoreControl[11];
        alphabetScore12.text = "" + scoreControl[12];
        alphabetScore13.text = "" + scoreControl[13];
        alphabetScore14.text = "" + scoreControl[14];
        alphabetScore15.text = "" + scoreControl[15];

        word.text = wordString;
    }


    public void AlphabetSelect1() {
        wordString += alphabetSetCollection[1];
        button1.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect2()
    {
        wordString += alphabetSetCollection[2];
        button2.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect3()
    {
        wordString += alphabetSetCollection[3];
        button3.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect4()
    {
        wordString += alphabetSetCollection[4];
        button4.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect5()
    {
        wordString += alphabetSetCollection[5];
        button5.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect6()
    {
        wordString += alphabetSetCollection[6];
        button6.interactable = false;
        refresh.interactable = true;
        check.interactable = true;
    }
    public void AlphabetSelect7()
    {
        wordString += alphabetSetCollection[7];
        button7.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect8()
    {
        wordString += alphabetSetCollection[8];
        button8.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect9()
    {
        wordString += alphabetSetCollection[9];
        button9.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect10()
    {
        wordString += alphabetSetCollection[10];
        button10.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect11()
    {
        wordString += alphabetSetCollection[11];
        button11.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect12()
    {
        wordString += alphabetSetCollection[12];
        button12.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect13()
    {
        wordString += alphabetSetCollection[13];
        button13.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect14()
    {
        wordString += alphabetSetCollection[14];
        button14.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect15()
    {
        wordString += alphabetSetCollection[15];
        button15.interactable = false;
        interactableFunction(true);
    }
    public void RefreshTheWord() {
        wordString = "";
        interactableAlphabet(true);
        interactableFunction(false);
    }
    public void CheckDictionary() {
        for (int i = 0; i < 15; i++) {
            for (int j = 0; j < wordString.Length; j++) {

            }
        }
        interactableAlphabet(true);
        interactableFunction(false);
    }
    public void interactableAlphabet(bool setBoolean) {
        button1.interactable = setBoolean;
        button2.interactable = setBoolean;
        button3.interactable = setBoolean;
        button4.interactable = setBoolean;
        button5.interactable = setBoolean;
        button6.interactable = setBoolean;
        button7.interactable = setBoolean;
        button8.interactable = setBoolean;
        button9.interactable = setBoolean;
        button10.interactable = setBoolean;
        button11.interactable = setBoolean;
        button12.interactable = setBoolean;
        button13.interactable = setBoolean;
        button14.interactable = setBoolean;
        button15.interactable = setBoolean;
    }
    public void interactableFunction(bool setBool) {
        refresh.interactable = setBool;
        check.interactable = setBool;
    }
    public void scoreCalculate() {
        int scoreInWord = 0;
        for (int i = 0; i < wordString.Length; i++) {
           switch (wordString.Substring(i, 1).ToLower()) {
                case "e":
                    scoreInWord += 1;
                    break;
                case "a":
                    scoreInWord += 1;
                    break;
                case "i":
                    scoreInWord += 1;
                    break;
                case "o":
                    scoreInWord += 1;
                    break;
                case "n":
                    scoreInWord += 1;
                    break;
                case "r":
                    scoreInWord += 1;
                    break;
                case "t":
                    scoreInWord += 1;
                    break;
                case "l":
                    scoreInWord += 1;
                    break;
                case "s":
                    scoreInWord += 1;
                    break;
                case "u":
                    scoreInWord += 1;
                    break;
                case "d":
                    scoreInWord += 2;
                    break;
                case "g":
                    scoreInWord += 2;
                    break;
                case "b":
                    scoreInWord += 3;
                    break;
                case "c":
                    scoreInWord += 3;
                    break;
                case "m":
                    scoreInWord += 3;
                    break;
                case "p":
                    scoreInWord += 3;
                    break;
                case "f":
                    scoreInWord += 4;
                    break;
                case "h":
                    scoreInWord += 4;
                    break;
                case "v":
                    scoreInWord += 4;
                    break;
                case "w":
                    scoreInWord += 4;
                    break;
                case "y":
                    scoreInWord += 4;
                    break;
                case "k":
                    scoreInWord += 5;
                    break;
                case "j":
                    scoreInWord += 8;
                    break;
                case "x":
                    scoreInWord += 8;
                    break;
                case "q":
                    scoreInWord += 10;
                    break;
                case "z":
                    scoreInWord += 10;
                    break;
            }
        }
    }
    public void AlphabetSetRandom() {
        string alphabetSelect = "";
        for (int i= alphabetSelect.Length ; i < 15 ; i++)
        {
            alphabetSelect = alphabetCollection[Random.Range(0, alphabetCollection.Length - 1)];
            alphabetSetCollection[i] = alphabetSelect;
        } 
    }
    public void AlphaScore() {
        for(int i = 0;i < 15;i++)
            switch (alphabetSetCollection[i].ToLower()) {
            case "e":
                    scoreControl[i] = 1;
                break;
            case "a":
                    scoreControl[i] = 1;
                break;
            case "i":
                    scoreControl[i] = 1;
                break;
            case "o":
                    scoreControl[i] = 1;
                break;
            case "n":
                    scoreControl[i] = 1;
                break;
            case "r":
                    scoreControl[i] = 1;
                break;
            case "t":
                    scoreControl[i] = 1;
                break;
            case "l":
                    scoreControl[i] = 1;
                break;
            case "s":
                    scoreControl[i] = 1;
                break;
            case "u":
                    scoreControl[i] = 1;
                break;
            case "d":
                    scoreControl[i] = 2;
                break;
            case "g":
                    scoreControl[i] = 2;
                break;
            case "b":
                    scoreControl[i] = 3;
                break;
            case "c":
                    scoreControl[i] = 3;
                break;
            case "m":
                    scoreControl[i] = 3;
                break;
            case "p":
                    scoreControl[i] = 3;
                break;
            case "f":
                    scoreControl[i] = 4;
                break;
            case "h":
                    scoreControl[i] = 4;
                break;
            case "v":
                    scoreControl[i] = 4;
                break;
            case "w":
                    scoreControl[i] = 4;
                break;
            case "y":
                    scoreControl[i] = 4;
                break;
            case "k":
                    scoreControl[i] = 5;
                break;
            case "j":
                    scoreControl[i] = 8;
                break;
            case "x":
                    scoreControl[i] = 8;
                break;
            case "q":
                    scoreControl[i] = 10;
                break;
            case "z":
                    scoreControl[i] = 10;
                break;
            default:
                    scoreControl[i] = 0;
                    break;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSystem : MonoBehaviour
{
    string alphabetSet="", wordString="";
    string[] wordArray = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    string[] alphabetSetCollection = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    string[] alphabetSetCollection2 = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
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
    public Text alphabet1, alphabet2,alphabet3, alphabet4, alphabet5, 
        alphabet6, alphabet7, alphabet8, alphabet9, alphabet10, 
        alphabet11, alphabet12, alphabet13, alphabet14, alphabet15,
        word, score, alphabetScore1, alphabetScore2, alphabetScore3, alphabetScore4
        , alphabetScore5, alphabetScore6, alphabetScore7, alphabetScore8
        , alphabetScore9, alphabetScore10, alphabetScore11, alphabetScore12
        , alphabetScore13, alphabetScore14, alphabetScore15, refreshCount;
    public Button button1, button2, button3, button4, button5, button6, button7, button8,
        button9, button10, button11, button12, button13, button14, button15,
        DeleteAll, check, Delete,Refresh;
    private int[] scoreControl = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    private int refreshCountTimes,scoreCount = 0;
    float startTimer = 180f;
    float currentTime = 0f;
    int[] wordSequence = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    void Start()
    {
        score.text = "Score : 0";
        interactableFunction(false);
        AlphabetSetRandom();
        AlphaScore();
        refreshCountTimes = 2;
        refreshCountDisplay();
        ScoreUpdate();
    }

    void Update()
    {
        AlphabetUpdate();
        word.text = wordString;
        if (refreshCountTimes == 0) {
            Refresh.interactable = false;
        }
    }

    public void AlphabetSelect1() {
        AddWordSequence(1);
        wordString += alphabetSetCollection[0];
        alphabetSetCollection2[0] = "";
        button1.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect2()
    {
        AddWordSequence(2);
        wordString += alphabetSetCollection[1];
        alphabetSetCollection2[1] = "";
        button2.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect3()
    {
        AddWordSequence(3); 
        wordString += alphabetSetCollection[2];
        alphabetSetCollection2[2] = "";
        button3.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect4()
    {
        AddWordSequence(4);
        wordString += alphabetSetCollection[3];
        alphabetSetCollection2[3] = "";
        button4.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect5()
    {
        AddWordSequence(5);
        wordString += alphabetSetCollection[4];
        alphabetSetCollection2[4] = "";
        button5.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect6()
    {
        AddWordSequence(6);
        wordString += alphabetSetCollection[5];
        alphabetSetCollection2[5] = "";
        button6.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect7()
    {
        AddWordSequence(7);
        wordString += alphabetSetCollection[6];
        alphabetSetCollection2[6] = "";
        button7.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect8()
    {
        AddWordSequence(8);
        wordString += alphabetSetCollection[7];
        alphabetSetCollection2[7] = "";
        button8.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect9()
    {
        AddWordSequence(9);
        wordString += alphabetSetCollection[8];
        alphabetSetCollection2[8] = "";
        button9.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect10()
    {
        AddWordSequence(10);
        wordString += alphabetSetCollection[9];
        alphabetSetCollection2[9] = "";
        button10.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect11()
    {
        AddWordSequence(11);
        wordString += alphabetSetCollection[10];
        alphabetSetCollection2[10] = "";
        button11.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect12()
    {
        AddWordSequence(12);
        wordString += alphabetSetCollection[11];
        alphabetSetCollection2[11] = "";
        button12.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect13()
    {
        AddWordSequence(13);
        wordString += alphabetSetCollection[12];
        alphabetSetCollection2[12] = "";
        button13.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect14()
    {
        AddWordSequence(14);
        wordString += alphabetSetCollection[13];
        alphabetSetCollection2[13] = "";
        button14.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect15()
    {
        AddWordSequence(15);
        wordString += alphabetSetCollection[14];
        alphabetSetCollection2[14] = "";
        button15.interactable = false;
        interactableFunction(true);
    }

    public void DeleteAllWord() {
        wordString = "";
        for (int i = 0; i < wordArray.Length;i++) {
            wordArray[i] = "";
        }
        wordSequence = new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        interactableAlphabet(true);
        interactableFunction(false);
    }
    public void DeleteWord() {
        wordString = wordString.Substring(0, wordString.Length - 1);
        int wordSequenceCheck = 0;
        for (int i = wordSequence.Length-1; i > 0; i--) {
            if (wordSequence[i] != 0) {
                wordSequenceCheck = wordSequence[i];
                wordSequence[i] = 0;
                wordString = wordString.Substring(0, i - 1);
                switch (wordSequenceCheck) {
                    case 1:
                        button1.interactable = true;
                        break;
                    case 2:
                        button2.interactable = true;
                        break;
                    case 3:
                        button3.interactable = true;
                        break;
                    case 4:
                        button4.interactable = true;
                        break;
                    case 5:
                        button5.interactable = true;
                        break;
                    case 6:
                        button6.interactable = true;
                        break;
                    case 7:
                        button7.interactable = true;
                        break;
                    case 8:
                        button8.interactable = true;
                        break;
                    case 9:
                        button9.interactable = true;
                        break;
                    case 10:
                        button10.interactable = true;
                        break;
                    case 11:
                        button11.interactable = true;
                        break;
                    case 12:
                        button12.interactable = true;
                        break;
                    case 13:
                        button13.interactable = true;
                        break;
                    case 14:
                        button14.interactable = true;
                        break;
                    case 15:
                        button15.interactable = true;
                        break;
                }
                alphabetSetCollection2[i] = alphabetSetCollection[i];
                break;
            }
        }
        
        for (int i = wordArray.Length; i < 0; i--)
        {
            if (wordArray[i] != "") {
                wordArray[i] = "";
                break;
            }
        }

        if (wordString.Length == 0) {
            interactableAlphabet(true);
            interactableFunction(false);
        }
    }
    public void CheckDictionary() {
        ScoreCalculate();
        ScoreUpdate();
        DeleteAllWord();
        alphabetSetCollection = alphabetSetCollection2;
        AlphabetSetRefill();
        AlphaScore();
        AlphabetUpdate();
        interactableAlphabet(true);
        interactableFunction(false);
    }
    public void RefreshWord()
    {
        if (refreshCountTimes > 0)
        {
            interactableAlphabet(true);
            DeleteAllWord();
            refreshCountTimes -= 1;
            refreshCountDisplay();
            AlphabetSetRandom();
            AlphaScore();
        }
        else {
            Refresh.interactable = false;
        }
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
        DeleteAll.interactable = setBool;
        check.interactable = setBool;
        Delete.interactable = setBool;
    }

    public void refreshCountDisplay() {
        refreshCount.text = "Refresh : " + refreshCountTimes;
    }

    public void ScoreUpdate() {
        score.text = "Score : " + scoreCount;
    }
    public void ScoreCalculate() {
        for (int i = 0; i < wordString.Length; i++) {
           switch (wordString.Substring(i, 1).ToLower()) {
                case "e":
                    scoreCount += 1;
                    break;
                case "a":
                    scoreCount += 1;
                    break;
                case "i":
                    scoreCount += 1;
                    break;
                case "o":
                    scoreCount += 1;
                    break;
                case "n":
                    scoreCount += 1;
                    break;
                case "r":
                    scoreCount += 1;
                    break;
                case "t":
                    scoreCount += 1;
                    break;
                case "l":
                    scoreCount += 1;
                    break;
                case "s":
                    scoreCount += 1;
                    break;
                case "u":
                    scoreCount += 1;
                    break;
                case "d":
                    scoreCount += 2;
                    break;
                case "g":
                    scoreCount += 2;
                    break;
                case "b":
                    scoreCount += 3;
                    break;
                case "c":
                    scoreCount += 3;
                    break;
                case "m":
                    scoreCount += 3;
                    break;
                case "p":
                    scoreCount += 3;
                    break;
                case "f":
                    scoreCount += 4;
                    break;
                case "h":
                    scoreCount += 4;
                    break;
                case "v":
                    scoreCount += 4;
                    break;
                case "w":
                    scoreCount += 4;
                    break;
                case "y":
                    scoreCount += 4;
                    break;
                case "k":
                    scoreCount += 5;
                    break;
                case "j":
                    scoreCount += 8;
                    break;
                case "x":
                    scoreCount += 8;
                    break;
                case "q":
                    scoreCount += 10;
                    break;
                case "z":
                    scoreCount += 10;
                    break;
            }
        }
    }

    public void AlphabetSetRandom() {
        string alphabetSelect = "";
        for (int i= alphabetSelect.Length ; i < alphabetSetCollection.Length; i++)
        {
            alphabetSelect = alphabetCollection[Random.Range(0, alphabetCollection.Length - 1)];
            alphabetSetCollection[i] = alphabetSelect;
            alphabetSetCollection2[i] = alphabetSelect;
        }
    }
    public void AlphabetSetRefill() {
        string alphabetSelect = "";
        for (int i = alphabetSelect.Length; i < alphabetSetCollection.Length; i++) {
            if (alphabetSetCollection[i] == "") {
                alphabetSelect = alphabetCollection[Random.Range(0, alphabetCollection.Length - 1)];
                alphabetSetCollection[i] = alphabetSelect;
                
            }
        }
        alphabetSetCollection2 = alphabetSetCollection;
    }
    public void AddToWordArray(string alphabetWord) {
        for (int i = 0 ; i < wordArray.Length ; i++) {
            if (wordArray[i] == "") {
                wordArray[i] = alphabetWord;
                break;
            }
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

    public void AlphabetUpdate(){
        alphabet1.text = alphabetSetCollection[0];
        alphabet2.text = alphabetSetCollection[1];
        alphabet3.text = alphabetSetCollection[2];
        alphabet4.text = alphabetSetCollection[3];
        alphabet5.text = alphabetSetCollection[4];
        alphabet6.text = alphabetSetCollection[5];
        alphabet7.text = alphabetSetCollection[6];
        alphabet8.text = alphabetSetCollection[7];
        alphabet9.text = alphabetSetCollection[8];
        alphabet10.text = alphabetSetCollection[9];
        alphabet11.text = alphabetSetCollection[10];
        alphabet12.text = alphabetSetCollection[11];
        alphabet13.text = alphabetSetCollection[12];
        alphabet14.text = alphabetSetCollection[13];
        alphabet15.text = alphabetSetCollection[14];

        alphabetScore1.text = ""+ scoreControl[0];
        alphabetScore2.text = "" + scoreControl[1];
        alphabetScore3.text = "" + scoreControl[2];
        alphabetScore4.text = "" + scoreControl[3];
        alphabetScore5.text = "" + scoreControl[4];
        alphabetScore6.text = "" + scoreControl[5];
        alphabetScore7.text = "" + scoreControl[6];
        alphabetScore8.text = "" + scoreControl[7];
        alphabetScore9.text = "" + scoreControl[8];
        alphabetScore10.text = "" + scoreControl[9];
        alphabetScore11.text = "" + scoreControl[10];
        alphabetScore12.text = "" + scoreControl[11];
        alphabetScore13.text = "" + scoreControl[12];
        alphabetScore14.text = "" + scoreControl[13];
        alphabetScore15.text = "" + scoreControl[14];
    }
    public void AddWordSequence(int buttonNumber)
    {
        for (int i = 0; i < 16; i++ ) {
            if (wordSequence[i] == 0) {
                wordSequence[i] = buttonNumber;
                break;
            }
        }
    }

}


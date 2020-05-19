using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSystem : MonoBehaviour
{
    string alphabetSet = "", alpha1, alpha2, alpha3, alpha4, alpha5, alpha6, alpha7, alpha8,
        alpha9, alpha10, alpha11, alpha12, alpha13, alpha14, alpha15, wordString, dictionary;
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
    private int scoreCount = 0,score1 = 0, score2 = 0, score3 = 0, score4 = 0
        , score5 = 0, score6 = 0, score7 = 0, score8 = 0, score9 = 0
        , score10 = 0, score11 = 0, score12 = 0, score13 = 0, score14 = 0
        , score15 = 0, scoreControl;

    void Start()
    {
        score.text = "Score : 0";
        dictionary = dictionaryFile.text;
        refresh.interactable = false;
        check.interactable = false;
    }


    void Update()
    {
        AlphabetSetRandom();
        alphaText.text = alphabetSet;

        alpha1 = alphabetSet.Substring(0, 1);
        alphabet1.text = alpha1;
        alpha2 = alphabetSet.Substring(1, 1);
        alphabet2.text = alpha2;
        alpha3 = alphabetSet.Substring(2, 1);
        alphabet3.text = alpha3;
        alpha4 = alphabetSet.Substring(3, 1);
        alphabet4.text = alpha4;
        alpha5 = alphabetSet.Substring(4, 1);
        alphabet5.text = alpha5;
        alpha6 = alphabetSet.Substring(5, 1);
        alphabet6.text = alpha6;
        alpha7 = alphabetSet.Substring(6, 1);
        alphabet7.text = alpha7;
        alpha8 = alphabetSet.Substring(7, 1);
        alphabet8.text = alpha8;
        alpha9 = alphabetSet.Substring(8, 1);
        alphabet9.text = alpha9;
        alpha10 = alphabetSet.Substring(9, 1);
        alphabet10.text = alpha10;
        alpha11 = alphabetSet.Substring(10, 1);
        alphabet11.text = alpha11;
        alpha12 = alphabetSet.Substring(11, 1);
        alphabet12.text = alpha12;
        alpha13 = alphabetSet.Substring(12, 1);
        alphabet13.text = alpha13;
        alpha14 = alphabetSet.Substring(13, 1);
        alphabet14.text = alpha14;
        alpha15 = alphabetSet.Substring(14, 1);
        alphabet15.text = alpha15;

        AlphaScore(alpha1);
        score1 = scoreControl;
        alphabetScore1.text += score1;

        AlphaScore(alpha2);
        score2 = scoreControl;
        alphabetScore2.text += score2;

        AlphaScore(alpha3);
        score3 = scoreControl;
        alphabetScore1.text += score3;

        AlphaScore(alpha4);
        score4 = scoreControl;
        alphabetScore1.text += score4;

        AlphaScore(alpha5);
        score5 = scoreControl;
        alphabetScore1.text += score5;

        AlphaScore(alpha6);
        score6 = scoreControl;
        alphabetScore1.text += score6;

        AlphaScore(alpha7);
        score7 = scoreControl;
        alphabetScore1.text += score7;

        AlphaScore(alpha8);
        score8 = scoreControl;
        alphabetScore1.text += score8;

        AlphaScore(alpha9);
        score9 = scoreControl;
        alphabetScore1.text += score9;

        AlphaScore(alpha10);
        score10 = scoreControl;
        alphabetScore1.text += score10;

        AlphaScore(alpha11);
        score11 = scoreControl;
        alphabetScore1.text += score11;

        AlphaScore(alpha12);
        score12 = scoreControl;
        alphabetScore1.text += score12;

        AlphaScore(alpha13);
        score13 = scoreControl;
        alphabetScore1.text += score13;

        AlphaScore(alpha14);
        score14 = scoreControl;
        alphabetScore1.text += score14;

        AlphaScore(alpha15);
        score15 = scoreControl;
        alphabetScore1.text += score15;

        word.text = wordString;
    }


    public void AlphabetSelect1() {
        wordString += alpha1;
        button1.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect2()
    {
        wordString += alpha2;
        button2.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect3()
    {
        wordString += alpha3;
        button3.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect4()
    {
        wordString += alpha4;
        button4.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect5()
    {
        wordString += alpha5;
        button5.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect6()
    {
        wordString += alpha6;
        button6.interactable = false;
        refresh.interactable = true;
        check.interactable = true;
    }
    public void AlphabetSelect7()
    {
        wordString += alpha7;
        button7.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect8()
    {
        wordString += alpha8;
        button8.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect9()
    {
        wordString += alpha9;
        button9.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect10()
    {
        wordString += alpha10;
        button10.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect11()
    {
        wordString += alpha11;
        button11.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect12()
    {
        wordString += alpha12;
        button12.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect13()
    {
        wordString += alpha13;
        button13.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect14()
    {
        wordString += alpha14;
        button14.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect15()
    {
        wordString += alpha15;
        button15.interactable = false;
        interactableFunction(true);
    }
    public void RefreshTheWord() {
        wordString = "";
        interactableAlphabet(true);
        interactableFunction(false);
    }
    public void CheckDictionary() {
        if (dictionary.Contains(wordString)) {
            interactableAlphabet(true);
            interactableFunction(false);
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
        while (alphabetSet.Length != 15)
        {
            alphabetSet = alphabetSet + alphabetCollection[Random.Range(0, alphabetCollection.Length - 1)];
        } 
    }
    public void AlphaScore(string alpha) {
        int alphaValue = 0;
            switch (alpha.ToLower()) {
            case "e":
                alphaValue = 1;
                break;
            case "a":
                alphaValue = 1;
                break;
            case "i":
                alphaValue = 1;
                break;
            case "o":
                alphaValue = 1;
                break;
            case "n":
                alphaValue = 1;
                break;
            case "r":
                alphaValue = 1;
                break;
            case "t":
                alphaValue = 1;
                break;
            case "l":
                alphaValue = 1;
                break;
            case "s":
                alphaValue = 1;
                break;
            case "u":
                alphaValue = 1;
                break;
            case "d":
                alphaValue = 2;
                break;
            case "g":
                alphaValue = 2;
                break;
            case "b":
                alphaValue = 3;
                break;
            case "c":
                alphaValue = 3;
                break;
            case "m":
                alphaValue = 3;
                break;
            case "p":
                alphaValue = 3;
                break;
            case "f":
                alphaValue = 4;
                break;
            case "h":
                alphaValue = 4;
                break;
            case "v":
                alphaValue = 4;
                break;
            case "w":
                alphaValue = 4;
                break;
            case "y":
                alphaValue = 4;
                break;
            case "k":
                alphaValue = 5;
                break;
            case "j":
                alphaValue = 8;
                break;
            case "x":
                alphaValue = 8;
                break;
            case "q":
                alphaValue = 10;
                break;
            case "z":
                alphaValue = 10;
                break;
        }
        Debug.Log(alphaValue);
        scoreControl = alphaValue;
    }
}


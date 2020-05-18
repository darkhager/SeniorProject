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
        word
        ;
    public Button button1, button2, button3, button4, button5, button6, button7, button8,
        button9, button10, button11, button12, button13, button14, button15,
        refresh, check;
    public TextAsset dictionaryFile;

    void Start()
    {
        dictionary = dictionaryFile.text;
        AlphabetSetRandom();
        refresh.interactable = false;
        check.interactable = false;
    }


    void Update()
    {
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
        AlphabetSetRandom();
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
    public void AlphabetSetRandom() {
        while (alphabetSet.Length != 15)
        {
            alphabetSet = alphabetSet + alphabetCollection[Random.Range(0, alphabetCollection.Length - 1)];
        } 
    }
}


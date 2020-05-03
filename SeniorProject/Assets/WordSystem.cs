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
    public string alpha1, alpha2, alpha3, alpha4, alpha5, alpha6, alpha7, alpha8,
        alpha9, alpha10, alpha11, alpha12, alpha13, alpha14, alpha15;
    void Start()
    {
        AlphabetSetRandom();
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
    }
    public void AlphabetSetRandom() {
        while (alphabetSet.Length != 15)
        {
            alphabetSet = alphabetSet + alphabetCollection[Random.Range(0, alphabetCollection.Length - 1)];
        }
    }
    public string GetAlphabet1() {
        return alpha1;
    }
    public string GetAlpha2
    {
        get { return alpha2; }
    }
    public string GetAlpha3
    {
        get { return alpha3; }
    }
    public string GetAlpha4
    {
        get { return alpha4; }
    }
    public string GetAlpha5
    {
        get { return alpha5; }
    }
        public string GetAlpha6
    {
        get { return alpha6; }
    }
    public string GetAlpha7
    {
        get { return alpha7; }
    }
    public string GetAlpha8
    {
        get { return alpha8; }
    }
    public string GetAlpha9
    {
        get { return alpha9; }
    }
    public string GetAlpha10
    {
        get { return alpha10; }
    }
    public string GetAlpha11
    {
        get { return alpha11; }
    }
    public string GetAlpha12
    {
        get { return alpha12; }
    }
    public string GetAlpha13
    {
        get { return alpha13; }
    }
    public string GetAlpha14
    {
        get { return alpha14; }
    }
    public string GetAlpha15
    {
        get { return alpha15; }
    }
}


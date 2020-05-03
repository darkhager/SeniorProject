using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Text wordText;
    private string wordGroup = "check";
    public void AlphabetSelect1() {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlphabet1();
    }
    public void AlphabetSelect2()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha2;
    }
    public void AlphabetSelect3()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha3;
    }
    public void AlphabetSelect4()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha4;
    }
    public void AlphabetSelect5()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha5;
    }
    public void AlphabetSelect6()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha6;
    }
    public void AlphabetSelect7()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha7;
    }
    public void AlphabetSelect8()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha8;
    }
    public void AlphabetSelect9()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha9;
    }
    public void AlphabetSelect10()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha10;
    }
    public void AlphabetSelect11()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha11;
    }
    public void AlphabetSelect12()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha12;
    }
    public void AlphabetSelect13()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha13;
    }
    public void AlphabetSelect14()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha14;
    }
    public void AlphabetSelect15()
    {
        wordGroup = wordGroup + gameObject.GetComponent<WordSystem>().GetAlpha15;
    }
    void Update()
    {
        wordText.text = wordGroup;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text wordText;
    string wordSet = "Set";
    public string SetWordSet
    {
        get { return wordSet; }
        set { wordSet = value; }
    }
    void Update()
    {
        wordText.text = wordSet;
    }
}

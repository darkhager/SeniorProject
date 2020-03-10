using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text wordText;
    string wordSet = "wordSet";
    private void Update()
    {
        wordText.text = wordSet;
    }
}

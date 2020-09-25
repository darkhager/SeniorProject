using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class wordDictionary : MonoBehaviour
{
    public TextAsset dict;
    public Dictionary<string, string> words = new Dictionary<string, string>();

    public static wordDictionary data;
    public bool wordCheck = false;

    void Start()
    {
        data = this;
        string[] separators = new[] { "\r\n", "\t" };
        string[] wordArray = dict.text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int i = 0;
        foreach (string s in wordArray)
        {
            words.Add(i.ToString(), s);
            i++;
        }
    }

    public void checkWord(string word) {
        Debug.Log("word check");
        word = word.ToLower();
        if (words.ContainsValue(word)){  
            wordCheck = true;
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    private string word = "";
    public Text wordText;

    private void Update()
    {
        wordText.text = word;
        if (Input.GetKeyDown(KeyCode.A)) {
            word = word+"A";
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            word = word + "B";
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            word = word + "C";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            word = word + "D";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            word = word + "E";
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            word = word + "F";
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            word = word + "G";
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            word = word + "H";
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            word = word + "I";
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            word = word + "J";
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            word = word + "K";
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            word = word + "L";
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            word = word + "M";
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            word = word + "N";
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            word = word + "O";
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            word = word + "P";
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            word = word + "Q";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            word = word + "R";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            word = word + "S";
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            word = word + "T";
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            word = word + "U";
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            word = word + "V";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            word = word + "W";
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            word = word + "X";
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            word = word + "Y";
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            word = word + "Z";
        }
        
    }
}

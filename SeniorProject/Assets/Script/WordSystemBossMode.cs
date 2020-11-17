using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSystemBossMode : MonoBehaviour
{
    string[] alphabetCollection = {
        "B", "B",//2
        "C", "C",//2
        "D", "D", "D", "D",//4
        "F", "F",//2
        "G", "G", "G",//3
        "H", "H",//2
        "J",//1
        "K",//1
        "L", "L", "L", "L",//4
        "M", "M",//2
        "N", "N", "N", "N", "N", "N",//6
        "P", "P",//2
        "Q",//1
        "R", "R", "R", "R", "R", "R",//6
        "S", "S", "S", "S",//4
        "T", "T", "T", "T", "T", "T",//6
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
    string alphabetSet = "", wordString = "";
    string[] wordArray = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    string[] alphabetSetCollection = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    string[] alphabetSetCollection2 = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    public Button alphabet1, alphabet2, alphabet3, alphabet4,
        alphabet5, alphabet6, alphabet7, alphabet8, alphabet9,
        alphabet10, alphabet11, alphabet12, alphabet13, alphabet14,
        alphabet15, DeleteAll, check, Delete, Refresh;
    public Text alphabetText1, alphabetText2, alphabetText3, alphabetText4,
        alphabetText5, alphabetText6, alphabetText7, alphabetText8, alphabetText9,
        alphabetText10, alphabetText11, alphabetText12, alphabetText13,
        alphabetText14, alphabetText15, alphabetScore1, alphabetScore2,
        alphabetScore3, alphabetScore4, alphabetScore5, alphabetScore6,
        alphabetScore7, alphabetScore8, alphabetScore9, alphabetScore10,
        alphabetScore11, alphabetScore12, alphabetScore13, alphabetScore14,
        alphabetScore15,
        word, refreshCount;
    private int[] scoreControl = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    private int refreshCountTimes, scoreCount = 0, currentHealth, maxHealth = 100;
    int[] wordSequence = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public wordDictionary dictScript;
    public HealthBar healthBar;

    void Start()
    {
        interactableFunction(false);
        AlphabetSetRefill();
        refreshCountTimes = 2;
        refreshCountDisplay();
    }

    void Update()
    {
        AlphabetUpdate();
        AlphaScore();
        word.text = wordString;
        if (refreshCountTimes == 0)
        {
            Refresh.interactable = false;
        }
    }

    public void AlphabetSelect1()/*ปุ่มเพิ่มอักษร*/
    {
        AddWordSequence(1);
        wordString += alphabetSetCollection[0];
        alphabetSetCollection2[0] = "";
        alphabet1.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect2()
    {
        AddWordSequence(2);
        wordString += alphabetSetCollection[1];
        alphabetSetCollection2[1] = "";
        alphabet2.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect3()
    {
        AddWordSequence(3);
        wordString += alphabetSetCollection[2];
        alphabetSetCollection2[2] = "";
        alphabet3.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect4()
    {
        AddWordSequence(4);
        wordString += alphabetSetCollection[3];
        alphabetSetCollection2[3] = "";
        alphabet4.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect5()
    {
        AddWordSequence(5);
        wordString += alphabetSetCollection[4];
        alphabetSetCollection2[4] = "";
        alphabet5.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect6()
    {
        AddWordSequence(6);
        wordString += alphabetSetCollection[5];
        alphabetSetCollection2[5] = "";
        alphabet6.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect7()
    {
        AddWordSequence(7);
        wordString += alphabetSetCollection[6];
        alphabetSetCollection2[6] = "";
        alphabet7.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect8()
    {
        AddWordSequence(8);
        wordString += alphabetSetCollection[7];
        alphabetSetCollection2[7] = "";
        alphabet8.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect9()
    {
        AddWordSequence(9);
        wordString += alphabetSetCollection[8];
        alphabetSetCollection2[8] = "";
        alphabet9.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect10()
    {
        AddWordSequence(10);
        wordString += alphabetSetCollection[9];
        alphabetSetCollection2[9] = "";
        alphabet10.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect11()
    {
        AddWordSequence(11);
        wordString += alphabetSetCollection[10];
        alphabetSetCollection2[10] = "";
        alphabet11.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect12()
    {
        AddWordSequence(12);
        wordString += alphabetSetCollection[11];
        alphabetSetCollection2[11] = "";
        alphabet12.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect13()
    {
        AddWordSequence(13);
        wordString += alphabetSetCollection[12];
        alphabetSetCollection2[12] = "";
        alphabet13.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect14()
    {
        AddWordSequence(14);
        wordString += alphabetSetCollection[13];
        alphabetSetCollection2[13] = "";
        alphabet14.interactable = false;
        interactableFunction(true);
    }
    public void AlphabetSelect15()
    {
        AddWordSequence(15);
        wordString += alphabetSetCollection[14];
        alphabetSetCollection2[14] = "";
        alphabet15.interactable = false;
        interactableFunction(true);
    }

    public void DeleteAllWord()/*ลบอักษรทั้งหมด*/
    {
        wordString = "";
        for (int i = 0; i < wordArray.Length; i++)
        {
            wordArray[i] = "";
        }
        interactableAlphabet(true);
        interactableFunction(false);
        clearWordSequence();
    }
    public void DeleteWord()/*ลบอักษรทีละตัว*/
    {
        int wordSequenceCheck = 0;
        for (int i = 14; i > -1; i--)
        {
            if (wordSequence[i] != 0)
            {
                wordSequenceCheck = wordSequence[i];
                wordSequence[i] = 0;
                wordString = wordString.Substring(0, i);
                switch (wordSequenceCheck)
                {
                    case 1:
                        alphabet1.interactable = true;
                        break;
                    case 2:
                        alphabet2.interactable = true;
                        break;
                    case 3:
                        alphabet3.interactable = true;
                        break;
                    case 4:
                        alphabet4.interactable = true;
                        break;
                    case 5:
                        alphabet5.interactable = true;
                        break;
                    case 6:
                        alphabet6.interactable = true;
                        break;
                    case 7:
                        alphabet7.interactable = true;
                        break;
                    case 8:
                        alphabet8.interactable = true;
                        break;
                    case 9:
                        alphabet9.interactable = true;
                        break;
                    case 10:
                        alphabet10.interactable = true;
                        break;
                    case 11:
                        alphabet11.interactable = true;
                        break;
                    case 12:
                        alphabet12.interactable = true;
                        break;
                    case 13:
                        alphabet13.interactable = true;
                        break;
                    case 14:
                        alphabet14.interactable = true;
                        break;
                    case 15:
                        alphabet15.interactable = true;
                        break;
                }
                alphabetSetCollection2[wordSequenceCheck - 1] = alphabetSetCollection[wordSequenceCheck - 1];
                break;
            }
        }

        for (int i = wordArray.Length; i < 0; i--)
        {
            if (wordArray[i] != "")
            {
                wordArray[i] = "";
                break;
            }
        }

        if (wordString.Length == 0)
        {
            interactableAlphabet(true);
            interactableFunction(false);
        }
    }
    public void CheckDictionary()/*ตรวจสอบคำและเช็คคะแนน*/
    {
        dictScript = GameObject.Find("Dictionary").GetComponent<wordDictionary>();
        bool Check = false;
        dictScript.checkWord(wordString);
        Check = dictScript.wordCheck;
        Debug.Log("" + Check);
        if (Check)
        {
            DamageCalculate();
            interactableFunction(false);
            interactableAlphabet(true);
            for (int i = 0; i < 15; i++)
            {
                alphabetSetCollection[i] = alphabetSetCollection2[i];
            }
            AlphabetSetRefill();
            wordString = "";
            clearWordSequence();
            AlphabetUpdate();
            AlphaScore();
        }
        else
        {
            DeleteAllWord();
        }
    }
    public void RefreshWord()/*เปลี่ยนชุดคำใหม่*/
    {
        interactableAlphabet(true);
        DeleteAllWord();
        refreshCountTimes -= 1;
        refreshCountDisplay();
        AlphabetSetReset();
        AlphabetSetRefill();
        AlphaScore();
        clearWordSequence();
    }

    public void interactableAlphabet(bool setBoolean)/*ตั้งค่าตัวอักษรให้กลับมาใช้งานได้*/
    {
        alphabet1.interactable = setBoolean;
        alphabet2.interactable = setBoolean;
        alphabet3.interactable = setBoolean;
        alphabet4.interactable = setBoolean;
        alphabet5.interactable = setBoolean;
        alphabet6.interactable = setBoolean;
        alphabet7.interactable = setBoolean;
        alphabet8.interactable = setBoolean;
        alphabet9.interactable = setBoolean;
        alphabet10.interactable = setBoolean;
        alphabet11.interactable = setBoolean;
        alphabet12.interactable = setBoolean;
        alphabet13.interactable = setBoolean;
        alphabet14.interactable = setBoolean;
        alphabet15.interactable = setBoolean;
    }
    public void interactableFunction(bool setBool)/*ตั้งค่าให้ปุ่ม delete check delete กลับมาใช้งานได้*/
    {
        DeleteAll.interactable = setBool;
        check.interactable = setBool;
        Delete.interactable = setBool;
        if (setBool)
        {
            Refresh.interactable = false;
        }
        else
        {
            Refresh.interactable = true;
        }

    }

    public void refreshCountDisplay()/*รีปุ่ม refresh ที่ ui*/
    {
        refreshCount.text = "Refresh : " + refreshCountTimes;
    }

    public void DamageCalculate()/*คำนวนคะแนนจาก wordString ไปเก็บไว้ที่ score count*/
    {
        for (int i = 0; i < wordString.Length; i++)
        {
            switch (wordString.Substring(i, 1).ToLower())
            {
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

    public void AlphabetSetRefill()/*เติมตัวอักษรให้ครบ 15 ตัว*/
    {
        string alphabetSelect = "";
        int vowelCounting = 0;
        for (int i = 0; i < 15; i++)
        {
            switch (alphabetSetCollection[i])
            {
                case "A":
                    vowelCounting++;
                    break;
                case "E":
                    vowelCounting++;
                    break;
                case "I":
                    vowelCounting++;
                    break;
                case "O":
                    vowelCounting++;
                    break;
                case "U":
                    vowelCounting++;
                    break;
                default:
                    break;
            }
        }
        while (vowelCounting != 3)
        {
            int randInt = Random.Range(0, 14);
            if (alphabetSetCollection[randInt] == "")
            {
                alphabetSelect = vowelCollection[Random.Range(0, vowelCollection.Length - 1)];
                alphabetSetCollection[randInt] = alphabetSelect;
                alphabetSetCollection2[randInt] = alphabetSelect;
                vowelCounting++;
            }
        }
        for (int i = 0; i < 15; i++)
        {
            if (alphabetSetCollection[i] == "")
            {
                alphabetSelect = alphabetCollection[Random.Range(0, alphabetCollection.Length - 1)];
                alphabetSetCollection[i] = alphabetSelect;
                alphabetSetCollection2[i] = alphabetSelect;
            }
        }
    }
    public void AlphabetSetReset()
    {
        for (int i = 0; i < 15; i++)
        {
            alphabetSetCollection[i] = "";
            alphabetSetCollection2[i] = "";
        }

    }
    public void AddToWordArray(string alphabetWord)/*ฟังชั่นเพิ่มตัวอักษรจากในปุ่มไปที่หน้าหลัก*/
    {
        for (int i = 0; i < wordArray.Length; i++)
        {
            if (wordArray[i] == "")
            {
                wordArray[i] = alphabetWord;
                break;
            }
        }
    }
    public void AlphaScore()/*ฟังชั่นในการระบุค่าคะแนนของตัวอักษรแต่ละตัว*/
    {
        for (int i = 0; i < 15; i++)
            switch (alphabetSetCollection[i].ToLower())
            {
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
    public void ClearScore()
    {
        for (int i = 0; i < 15; i++)
        {
            scoreControl[i] = 0;
        }
    }

    public void AlphabetUpdate()/*อัพเดทตัวอักษรที่ ui*/
    {
        alphabetText1.text = alphabetSetCollection[0];
        alphabetText2.text = alphabetSetCollection[1];
        alphabetText3.text = alphabetSetCollection[2];
        alphabetText4.text = alphabetSetCollection[3];
        alphabetText5.text = alphabetSetCollection[4];
        alphabetText6.text = alphabetSetCollection[5];
        alphabetText7.text = alphabetSetCollection[6];
        alphabetText8.text = alphabetSetCollection[7];
        alphabetText9.text = alphabetSetCollection[8];
        alphabetText10.text = alphabetSetCollection[9];
        alphabetText11.text = alphabetSetCollection[10];
        alphabetText12.text = alphabetSetCollection[11];
        alphabetText13.text = alphabetSetCollection[12];
        alphabetText14.text = alphabetSetCollection[13];
        alphabetText15.text = alphabetSetCollection[14];

        alphabetScore1.text = "" + scoreControl[0];
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
    public void AddWordSequence(int buttonNumber)/*ทำลำดับตัวอักษรไว้ใข้ลบคำ*/
    {
        for (int i = 0; i < 16; i++)
        {
            if (wordSequence[i] == 0)
            {
                wordSequence[i] = buttonNumber;
                break;
            }
        }
    }
    public void clearWordSequence()
    {
        for (int i = 0; i < 15; i++)
        {
            wordSequence[i] = 0;
        }
    }
}

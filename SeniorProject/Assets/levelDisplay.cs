using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelDisplay : MonoBehaviour
{
    private int level = 15;
    public Text levelText;
    public void Update()
    {
        levelText.text = "level " + level / 10 + "-" + level % 10;
    }
}

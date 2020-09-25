using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManage : MonoBehaviour
{
    private float score = 0f;
    private List<string> wordHistory = new List<string>();

    [System.Serializable]
    public class PlayerData {
        public string name;
        public int score;
        public int refresh;
        public List<string> inventory;
    }

    public void SavePlayerData() {
        PlayerData playerData = new PlayerData
        {
            
        };
    }
}

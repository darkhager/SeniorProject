using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManage : MonoBehaviour
{
    private float score = 0f;
    private List<string> wordHistory = new List<string>();
    private int bossHealth = 1000;
    private int playerHealth = 1000;
    private float Timer;
    public wordDictionary dictScript;

    [System.Serializable]
    public class PlayerData {
        public string name;
        public int score;
        public int refresh;
        public List<string> inventory;
    }

    private void Update()
    {
        Timer += Time.deltaTime;
        if (Timer % 10 == 0) {
            PlayerHealthManage(false,Random.Range(8, 13));
        }
    }

    public void SavePlayerData() {
        PlayerData playerData = new PlayerData
        {
            
        };
    }

    public void PlayerHealthManage(bool healthChange, int healthChangeAmount) {
        if (healthChange)
        {
            playerHealth = playerHealth + healthChangeAmount;
        }
        else
        {
            playerHealth = playerHealth - healthChangeAmount;
        }
    }
    public void BossHealthManage(bool healthChange, int healthChangeAmount)
    {
        if (healthChange)
        {
            bossHealth = bossHealth + healthChangeAmount;
        }
        else {
            bossHealth = bossHealth - healthChangeAmount;
        }
    }
}

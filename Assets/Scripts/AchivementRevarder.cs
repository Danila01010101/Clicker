using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementRevarder : MonoBehaviour
{
    private CoinStacker _coinStacker;
    public Achivement[] achivements;
    [System.Serializable]
    public class Achivement
    {
        public string Name;
        public Image icon;
        public string Description;
        public int goal;
        public int revard;
        public bool isUnlocked;
        public bool isRevardTaken;
    }
    void Start()
    {
        foreach (Achivement _achivement in achivements)
        {
            _achivement.isUnlocked = intToBool(PlayerPrefs.GetInt(_achivement.Name + "isUnlocked"));
            _achivement.isRevardTaken = intToBool(PlayerPrefs.GetInt(_achivement.Name + "isRevardTaken"));
        }
        _coinStacker = GameObject.Find("GameManager").GetComponent<CoinStacker>();
        InvokeRepeating("CheckAchivements", 0, 0.5f);
    }

    public void GetRevard(int ID)
    {
        if (achivements[ID].isRevardTaken == false && achivements[ID].isUnlocked == true)
        {
            _coinStacker.AddCoins(achivements[ID].revard);
            achivements[ID].isRevardTaken = true;
            PlayerPrefs.SetInt(achivements[ID].Name + "isRevardTaken", 1);
        }
    }

    public void CheckAchivements()
    {
        foreach (Achivement _achivement in achivements)
        {
            if (_achivement.isUnlocked != false || _coinStacker.GetCoins() < _achivement.goal)
            {
                continue;
            }
            _achivement.isUnlocked = true;
            PlayerPrefs.SetInt(_achivement.Name + "isUnlocked", 1);
        }
    }

    public bool intToBool(int num)
    {
        if (num == 1)
            return true;
        else
            return false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinStacker : MonoBehaviour
{
    public int _coins;
    private int _numOfAddingCoins = 1;
    private int _passiveIncome = 0;
    public Idle[] idles;

    void Start()
    {
        LoadStats();
        InvokeRepeating("AddIncome", 0.5f ,0.5f);
    }

    public void ButtonClick()
    {
        _coins += _numOfAddingCoins;
    }


    public void AddIncome()
    {
        _coins += _passiveIncome;
        SaveCoins();
    }

    public int GetCoins()
    {
        return _coins;
    }
    public void ResetButton()
    {
        PlayerPrefs.DeleteAll();
        _passiveIncome = 0;
        _coins = 0;
    }


    public void AddCoins(int revardInCoins)
    {
        _coins += revardInCoins;
    }

    public void BuyIdle(Idle idle)
    {

        if (_coins >= idle.Cost)
        {
            _coins -= idle.Cost;
            _passiveIncome += idle.Income;
            idle.Cost *= 2;
            PlayerPrefs.SetInt(idle.Name.ToString() + "Cost", idle.Cost);
            PlayerPrefs.SetInt("_passiveIncome", _passiveIncome);
        }
    }

    [System.Serializable]
    public class Idle
    {
        [SerializeField] public string Name;
        [SerializeField] public int Cost;
        [SerializeField] public int Income;
    }

    public void BuyCatWorker()
    {
        BuyIdle(idles[0]);
    }

    public void BuyCatFactory()
    {
        BuyIdle(idles[1]);
    }

    public void BuyBusinessCat()
    {
        BuyIdle(idles[3]);
    }
    public void BuyAdvertCat()
    {
        BuyIdle(idles[2]);
    }

    public void BuyMegaFactory()
    {
        BuyIdle(idles[4]);
    }
    public void BuyWorkingTown()
    {
        BuyIdle(idles[5]);
    }

    public void SaveCoins()
    {
        PlayerPrefs.SetInt("_coins", _coins);
    }

    public void LoadStats()
    {
        _coins = PlayerPrefs.GetInt("_coins", _coins);
        _passiveIncome = PlayerPrefs.GetInt("_passiveIncome", _passiveIncome);
        foreach (Idle idle in idles)
        {
            idle.Cost = PlayerPrefs.GetInt(idle.Name.ToString() + "Cost", idle.Cost);
        }

    }
    public int GetIdleCost(int id)
    {
        return idles[id].Cost;
    }
    public int GetIncome()
    {
        return _passiveIncome;
    }
}

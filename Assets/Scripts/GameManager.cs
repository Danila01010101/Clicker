using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _coins;
    public Text _coinsValue;
    private int _income;
    private CoinStacker _coinStacker;
    private AchivementRevarder _achivementRevarder;
    public Text _IncomeText;
    void Start()
    {
        _coinStacker = GetComponent<CoinStacker>();
        _achivementRevarder = GetComponent<AchivementRevarder>();
    } 

    void Update()
    {
        _coins = _coinStacker.GetCoins();
        _income = _coinStacker.GetIncome() * 2;
        _coinsValue.text = _coins.ToString();
        _IncomeText.text = _income.ToString();
    }
}

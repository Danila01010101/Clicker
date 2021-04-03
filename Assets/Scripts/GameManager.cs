using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _coins;
    public Text _coinsValue;
    private CoinStacker _coinStacker;
    public AchivementRevarder _achivementRevarder;
    void Start()
    {
        _coinStacker = GetComponent<CoinStacker>();
        _achivementRevarder = GetComponent<AchivementRevarder>();
    } 


    void Update()
    {
        _coins = _coinStacker.GetCoins();
        _coinsValue.text = _coins.ToString();
    }
}

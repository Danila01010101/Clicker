using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleHolder : MonoBehaviour
{
    public int ID;
    public CoinStacker _coinStacker;
    private GameObject _gameManager;
    public Text _costText;
    void Start()
    {
        _gameManager = GameObject.Find("GameManager");
        _coinStacker = _gameManager.GetComponent<CoinStacker>();
        _costText.text = _coinStacker.GetIdleCost(ID).ToString();
    }

    void Update()
    {
        
    }
    public void UpdateCost()
    {
        _costText.text = _coinStacker.GetIdleCost(ID).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleHolder : MonoBehaviour
{
    public int ID;
    private CoinStacker _coinStacker;
    private GameObject _gameManager;
    private Transform _thisGameObject;
    private Text _costText;
    private int _cost;
    void Start()
    {
        _thisGameObject = this.gameObject.transform.Find("Cost");
        _costText = _thisGameObject.GetComponent<Text>();
        _gameManager = GameObject.Find("GameManager");
        _coinStacker = _gameManager.GetComponent<CoinStacker>();
    }

    void Update()
    {
        _costText.text = _coinStacker.GetIdleCost(ID).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneLoader : MonoBehaviour
{
    public CoinStacker _coinStacker;
    // Start is called before the first frame update
    void Start()
    {
        _coinStacker = GameObject.Find("GameManager").GetComponent<CoinStacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadAchivments()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadShop()
    {
        SceneManager.LoadScene(2);
    }   
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

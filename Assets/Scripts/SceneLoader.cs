using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneLoader : MonoBehaviour
{

    public void LoadAchivments()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadShop()
    {
        SceneManager.LoadScene(3);
    }   
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}

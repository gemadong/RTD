using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RobbyManager : MonoBehaviour
{
    [SerializeField] private Text moneyText;


    private void Update()
    {
        moneyText.text = "$ " + Singleton.instance.money;
    }


    public void MoneyPlus(int plus)
    {
        Singleton.instance.money += plus;
    }















    public void FastGameStart()
    {
        SceneManager.LoadScene("FastScene");
    }
    
    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}

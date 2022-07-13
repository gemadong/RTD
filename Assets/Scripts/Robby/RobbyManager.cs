using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RobbyManager : MonoBehaviour
{
    [SerializeField] private Text moneyText;


    public int money;
    public float[] currentIngredient;


    private void Update()
    {
        moneyText.text = "$ " + money.ToString();
    }


    public void MoneyPlus(int plus)
    {
        money += plus;
    }















    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}

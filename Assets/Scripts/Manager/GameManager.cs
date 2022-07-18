using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerHP playerHp;
    [SerializeField] private TimeManager TM;
    [SerializeField] private GameObject Over;
    [SerializeField] private GameObject Clear;
    [SerializeField] private Text[] itemCount;
    [SerializeField] private int moneyP;
    [SerializeField] private int ingredientP;
    [SerializeField] private int[] itemCounting;

    private void Start()
    {
        for(int i = 0; i < 8; i++)
        {
            itemCounting[i] = 0;
        }
    }
    private void Update()
    {
        if(playerHp.CurrentHP <= 0)
        {
            Time.timeScale = 0f;
            TM.isStop = true;
            Over.SetActive(true);
        }
    }
    public void GameClear()
    {
        Time.timeScale = 0f;
        TM.isStop = true;
        Clear.SetActive(true);
        Singleton.instance.money += moneyP;
        for(int i = 0; i < ingredientP; i++)
        {
            int a = Random.Range(0, 8);
            itemCounting[a]++;
            Singleton.instance.currentIngredient[a] += 1;
        }
        for(int i = 0; i <8; i++)
        {
            itemCount[i].text = "x  " + itemCounting[i];
        }
    }
    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void RobbyStart()
    {
        SceneManager.LoadScene("RobbyScene");
    }


}

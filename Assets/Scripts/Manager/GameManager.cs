using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerHP playerHp;
    [SerializeField] private TimeManager TM;
    [SerializeField] private GameObject Over;
    [SerializeField] private GameObject Clear;
    [SerializeField] private int moneyP;
    [SerializeField] private int ingredientP;

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
            Singleton.instance.currentIngredient[a] += 1;
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

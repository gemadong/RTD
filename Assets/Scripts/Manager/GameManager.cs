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

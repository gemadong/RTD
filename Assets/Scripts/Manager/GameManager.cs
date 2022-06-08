using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerHP playerHp;
    [SerializeField] private TimeManager TM;

    private void Update()
    {
        if(playerHp.CurrentHP <= 0)
        {
            Time.timeScale = 0f;
            TM.isStop = true;
        }
    }



}

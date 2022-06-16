using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text quickness;

    int isSpeed = 1;

    public bool isStop = false;


    public void SpeedUp()
    {
        if (!isStop)
        {
            if (isSpeed == 1)
            {
                isSpeed = 2;
                Time.timeScale = 2f;
                quickness.text = "x2";
            }
            else if(isSpeed == 2)
            {
                isSpeed = 3;
                Time.timeScale = 20f;
                quickness.text = "x3";
            }
            else
            {
                isSpeed = 1;
                Time.timeScale = 1f;
                quickness.text = "x1";
            }
        }
    }

    public void IsStop()
    {
        if (!isStop)
        {
            Time.timeScale = 0f;
            isStop = true;
        }
        else if (isStop)
        {
            isSpeed -= 1;
            isStop = false;
            SpeedUp();
        }
    }

}

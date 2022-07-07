using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField] private UpGrade upGrade;
    [SerializeField] private Mission mission;
    [SerializeField] private Hidden hidden;
    [SerializeField] private Draw draw;
    [SerializeField] private TimeManager TM;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject robbypanel;
    [SerializeField] private GameObject retrypanel;
    [SerializeField] private Slider soundSlider;

    public bool ispanel = false;
    public bool isrobbypanel = false;
    public bool isretrypanel = false;
    public bool isSound = false;

    private float soundvalue = 0f;

    public void IsReTryPanel()
    {
        if (!isretrypanel)
        {
            retrypanel.SetActive(true);
            isretrypanel = true;
        }
        else
        {
            retrypanel.SetActive(false);
            isretrypanel = false;
        }
    }

    public void IsRobbyPanel()
    {
        if (!isrobbypanel)
        {
            robbypanel.SetActive(true);
            isrobbypanel = true;
        }
        else
        {
            robbypanel.SetActive(false);
            isrobbypanel = false;
        }
    }

    public void IsPanel()
    {
        if (!ispanel)
        {
            if (mission.ispanel == true) mission.IsPanel();
            if (hidden.ispanel == true) hidden.IsPanel();
            if (upGrade.ispanel == true) upGrade.IsPanel();
            if (draw.ispanel == true) draw.IsPanel();
            TM.IsStop();
            panel.SetActive(true);
            ispanel = true;
        }
        else
        {
            if (isretrypanel) IsReTryPanel();
            if (isrobbypanel) IsRobbyPanel();
            TM.IsStop();
            panel.SetActive(false);
            ispanel = false;
        }
    }

    public void IsSound()
    {
        if (!isSound) 
        { 
            soundvalue = soundSlider.value;
            soundSlider.value = 0f;
            isSound = true;
        }
        else
        {
            soundSlider.value = soundvalue;
            isSound = false;
        }
    }
}

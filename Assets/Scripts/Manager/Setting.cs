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
    [SerializeField] private Slider soundSlider;

    public bool ispanel = false;
    public bool isSound = false;

    private float soundvalue = 0f;

    
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

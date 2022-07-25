using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Draw : MonoBehaviour
{
    [SerializeField] private Setting setting;
    [SerializeField] private TutorialObjectDetector TOD;
    [SerializeField] private PlayerGold PG;
    [SerializeField] private UnitSpawner US;
    [SerializeField] private UpGrade upGrade;
    [SerializeField] private Mission mission;
    [SerializeField] private Hidden hidden;
    [SerializeField] private Text[] numberText;
    [SerializeField] private GameObject panel;

    public int draw = 0;
    public int rare = 0;
    public int unique = 0;
    public int epic = 0;

    public bool ispanel = false;

    private void Update()
    {
        numberText[0].text = "»Ì±â(" + draw + ")";
        numberText[1].text = "(" + rare + ")";
        numberText[2].text = "(" + unique + ")";
        numberText[3].text = "(" + epic + ")";
    }

    public void Rare(int i)
    {
        if (rare >= 1)
        {
            US.isdraw = true;
            US.drawUnit.Add(US.unit3Prefab[i]);
            rare -= 1;

            if(TOD != null&&TOD.tutorialCount==32)
            {
                TOD.TutorialPanel();
                IsPanel();
            }
        }
    }

    public void Unique(int i)
    {
        if (unique >= 1)
        {
            US.isdraw = true;
            US.drawUnit.Add(US.unit4Prefab[i]);
            unique -= 1;
        }
    }

    public void Epic(int i)
    {
        if (epic >= 1)
        {
            US.isdraw = true;
            US.drawUnit.Add(US.unit5Prefab[i]);
            epic -= 1;
        }
    }

    public void DrawB(int i)
    {
        if(draw >= 1)
        {
            if(i== 1)
            {
                if (TOD != null && TOD.tutorialCount == 30)
                {
                    return;
                }
                PG.CurrentGold += 400;
            }
            if (i == 2)
            {
                if (TOD != null && TOD.tutorialCount == 30)
                {
                    return;
                }
                PG.CurrentGas += 200;
            }
            if (i == 3)
            {
                if (TOD != null && TOD.tutorialCount == 30)
                {
                    TOD.TutorialPanel();
                }
                rare += 1;
            }
            draw -= 1;
        }
    }

    public void IsPanel()
    {
        if (!ispanel)
        {
            if (mission.ispanel == true) mission.IsPanel();
            if (hidden.ispanel == true) hidden.IsPanel();
            if (upGrade.ispanel == true) upGrade.IsPanel();
            if (setting.ispanel == true) setting.IsPanel();
            if (TOD != null)
            {
                if (TOD.tutorialCount == 28)
                {
                    TOD.TutorialPanel();
                    draw += 1;
                }
            }
            panel.SetActive(true);
            ispanel = true;
        }
        else
        {
            panel.SetActive(false);
            ispanel = false;
        }
    }
}

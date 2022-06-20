using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGrade : MonoBehaviour
{
    [SerializeField] private Setting setting;
    [SerializeField] private Mission mission;
    [SerializeField] private Draw draw;
    [SerializeField] private Hidden hidden;
    [SerializeField] private GameObject panel;
    [SerializeField] private UnitSpawner US;
    [SerializeField] private PlayerGold PG;
    [SerializeField] private Text[] CostText;
    [SerializeField] private Text plusGas;

    public bool ispanel = false;
    public bool isText = false;

    public int cost1 = 10;
    public int cost2 = 10;
    public int cost3 = 10;
    public int cost4 = 10;
    public int cost5 = 10;
    public int cost6 = 10;
    public int cost7 = 10;
    public int cost8 = 10;
    public int randomGas = 0;

    float colora = 0;
    Color recolor;

    private void Start()
    {
        for(int i = 0; i < 8; i++)
        {
            US.unit1Prefab[i].GetComponent<UnitWeapon>().upGrade = 0;
            US.unit2Prefab[i].GetComponent<UnitWeapon>().upGrade = 0;
            US.unit3Prefab[i].GetComponent<UnitWeapon>().upGrade = 0;
            US.unit4Prefab[i].GetComponent<UnitWeapon>().upGrade = 0;
            US.unit5Prefab[i].GetComponent<UnitWeapon>().upGrade = 0;
        }
        cost1 = 10;
        cost2 = 10;
        cost3 = 10;
        cost4 = 10;
        cost5 = 10;
        cost6 = 10;
        cost7 = 10;
        cost8 = 10;
        randomGas = 0;
        recolor = plusGas.color;
        
    }
    private void Update()
    {
        CostText[0].text = "Gas : " + cost1;
        CostText[1].text = "Gas : " + cost2;
        CostText[2].text = "Gas : " + cost3;
        CostText[3].text = "Gas : " + cost4;
        CostText[4].text = "Gas : " + cost5;
        CostText[5].text = "Gas : " + cost6;
        CostText[6].text = "Gas : " + cost7;
        CostText[7].text = "Gas : " + cost8;

        if (isText)
        {
            colora -= Time.deltaTime;
            plusGas.text = "+" + randomGas.ToString();
            recolor.a = colora;
            plusGas.color = recolor;
            if (recolor.a <= 0)
            {
                plusGas.gameObject.SetActive(false);
                isText = false;
            }
        }

    }
    public void unitUpGrade1()
    {
        if(PG.CurrentGas >= cost1)
        {
            PG.CurrentGas -= cost1;
            unitUpGrade(0,10f);
            InunitUpHrade(10f, UnitType.Type1);
            cost1 += 1;

        }
    }
    public void unitUpGrade2()
    {
        if (PG.CurrentGas >= cost2)
        {
            PG.CurrentGas -= cost2;
            unitUpGrade(1, 10f);
            InunitUpHrade(10f, UnitType.Type2);
            cost2 += 1;

        }
    }
    public void unitUpGrade3()
    {
        if (PG.CurrentGas >= cost3)
        {
            PG.CurrentGas -= cost3;
            unitUpGrade(2, 10f);
            InunitUpHrade(10f, UnitType.Type3);
            cost3 += 1;
        }
    }
    public void unitUpGrade4()
    {
        if (PG.CurrentGas >= cost4)
        {
            PG.CurrentGas -= cost4;
            unitUpGrade(3, 10f);
            InunitUpHrade(10f, UnitType.Type4);
            cost4 += 1;
        }
    }
    public void unitUpGrade5()
    {
        if (PG.CurrentGas >= cost5)
        {
            PG.CurrentGas -= cost5;
            unitUpGrade(4, 10f);
            InunitUpHrade(10f, UnitType.Type5);
            cost5 += 1;
        }
    }
    public void unitUpGrade6()
    {
        if (PG.CurrentGas >= cost6)
        {
            PG.CurrentGas -= cost6;
            unitUpGrade(5, 10f);
            InunitUpHrade(10f, UnitType.Type6);
            cost6 += 1;
        }
    }
    public void unitUpGrade7()
    {
        if (PG.CurrentGas >= cost7)
        {
            PG.CurrentGas -= cost7;
            unitUpGrade(6, 10f);
            InunitUpHrade(10f, UnitType.Type7);
            cost7 += 1;
        }
    }
    public void unitUpGrade8()
    {
        if (PG.CurrentGas >= cost8)
        {
            PG.CurrentGas -= cost8;
            unitUpGrade(7, 10f);
            InunitUpHrade(10f, UnitType.Type8);
            cost8 += 1;
        }
    }

    public void unitUpGrade(int i, float j)
    {
        US.unit1Prefab[i].GetComponent<UnitWeapon>().PowerUP(j);
        US.unit2Prefab[i].GetComponent<UnitWeapon>().PowerUP(j);
        US.unit3Prefab[i].GetComponent<UnitWeapon>().PowerUP(j);
        US.unit4Prefab[i].GetComponent<UnitWeapon>().PowerUP(j);
        US.unit5Prefab[i].GetComponent<UnitWeapon>().PowerUP(j);
    }

    public void InunitUpHrade(float power, UnitType unitType)
    {
        for (int i = 0; i < US.unit1.Count; i++)
        {
            if (US.unit1[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                US.unit1[i].GetComponent<UnitWeapon>().PowerUP(power);
            }
        }
        for (int i = 0; i < US.unit2.Count; i++)
        {
            if (US.unit2[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                US.unit2[i].GetComponent<UnitWeapon>().PowerUP(power);
            }
        }
        for (int i = 0; i < US.unit3.Count; i++)
        {
            if (US.unit3[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                US.unit3[i].GetComponent<UnitWeapon>().PowerUP(power);
            }
        }
        for (int i = 0; i < US.unit4.Count; i++)
        {
            if (US.unit4[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                US.unit4[i].GetComponent<UnitWeapon>().PowerUP(power);
            }
        }
        for (int i = 0; i < US.unit5.Count; i++)
        {
            if (US.unit5[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                US.unit5[i].GetComponent<UnitWeapon>().PowerUP(power);
            }
        }
    }

    public void RandomGas()
    {
        if (PG.CurrentGold >= 100)
        {
            PG.CurrentGold -= 100;
            randomGas = Random.Range(2, 11) * 10;
            PG.CurrentGas += randomGas;
            colora = 1f;
            isText = true;
            plusGas.gameObject.SetActive(true);

        }
    }

    public void IsPanel()
    {
        if (!ispanel)
        {
            if (mission.ispanel == true) mission.IsPanel();
            if (hidden.ispanel == true) hidden.IsPanel();
            if (draw.ispanel == true) draw.IsPanel();
            if (setting.ispanel == true) setting.IsPanel();
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

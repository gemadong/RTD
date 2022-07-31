using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpGrade : MonoBehaviour
{
    [SerializeField] private Setting setting;
    [SerializeField] private TutorialObjectDetector TOD;
    [SerializeField] private WaveManager WM;
    [SerializeField] private Mission mission;
    [SerializeField] private Draw draw;
    [SerializeField] private Hidden hidden;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject effect;
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

    float normaltype1;
    float normaltype2;
    float normaltype3;
    float normaltype4;
    float normaltype5;
    float normaltype6;
    float normaltype7;
    float normaltype8;
    float magictype1;
    float magictype2;
    float magictype3;
    float magictype4;
    float magictype5;
    float magictype6;
    float magictype7;
    float magictype8;
    float raretype1;
    float raretype2;
    float raretype3;
    float raretype4;
    float raretype5;
    float raretype6;
    float raretype7;
    float raretype8;
    float uniquetype1;
    float uniquetype2;
    float uniquetype3;
    float uniquetype4;
    float uniquetype5;
    float uniquetype6;
    float uniquetype7;
    float uniquetype8;
    float epictype1;
    float epictype2;
    float epictype3;
    float epictype4;
    float epictype5;
    float epictype6;
    float epictype7;
    float epictype8;

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
        
        
        normaltype1 = 6;
        normaltype2 = 13;
        normaltype3 = 30;
        normaltype4 = 18;
        normaltype5 = 15;
        normaltype6 = 8;
        normaltype7 = 5;
        normaltype8 = 10;
        magictype1 = 9;
        magictype2 = 18;
        magictype3 = 45;
        magictype4 = 37;
        magictype5 = 24;
        magictype6 = 12;
        magictype7 = 9;
        magictype8 = 15;
        raretype1 = 12;
        raretype2 = 26;
        raretype3 = 60;
        raretype4 = 36;
        raretype5 = 30;
        raretype6 = 16;
        raretype7 = 10;
        raretype8 = 20;
        uniquetype1 = 18;
        uniquetype2 = 39;
        uniquetype3 = 90;
        uniquetype4 = 54;
        uniquetype5 = 45;
        uniquetype6 = 24;
        uniquetype7 = 15;
        uniquetype8 = 30;
        epictype1 = 21;
        epictype2 = 45;
        epictype3 = 105;
        epictype4 = 63;
        epictype5 = 53;
        epictype6 = 28;
        epictype7 = 18;
        epictype8 = 35;

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
            unitUpGrade(0,normaltype1,magictype1,raretype1,uniquetype1,epictype1);
            InunitUpHrade(normaltype1, magictype1, raretype1, uniquetype1, epictype1, UnitType.Type1);
            cost1 += 1;

        }
    }
    public void unitUpGrade2()
    {
        if (PG.CurrentGas >= cost2)
        {
            PG.CurrentGas -= cost2;
            unitUpGrade(1, normaltype2,magictype2,raretype2,uniquetype2,epictype2);
            InunitUpHrade(normaltype2, magictype2, raretype2, uniquetype2, epictype2, UnitType.Type2);
            cost2 += 1;

        }
    }
    public void unitUpGrade3()
    {
        if (PG.CurrentGas >= cost3)
        {
            PG.CurrentGas -= cost3;
            unitUpGrade(2, normaltype3, magictype3, raretype3, uniquetype3, epictype3);
            InunitUpHrade(normaltype3, magictype3, raretype3, uniquetype3, epictype3, UnitType.Type3);
            cost3 += 1;
        }
    }
    public void unitUpGrade4()
    {
        if (PG.CurrentGas >= cost4)
        {
            PG.CurrentGas -= cost4;
            unitUpGrade(3, normaltype4, magictype4, raretype4, uniquetype4, epictype4);
            InunitUpHrade(normaltype4, magictype4, raretype4, uniquetype4, epictype4, UnitType.Type4);
            cost4 += 1;
        }
    }
    public void unitUpGrade5()
    {
        if (PG.CurrentGas >= cost5)
        {
            PG.CurrentGas -= cost5;
            unitUpGrade(4, normaltype5, magictype5, raretype5, uniquetype5, epictype5);
            InunitUpHrade(normaltype5, magictype5, raretype5, uniquetype5, epictype5, UnitType.Type5);
            cost5 += 1;
        }
    }
    public void unitUpGrade6()
    {
        if (PG.CurrentGas >= cost6)
        {
            PG.CurrentGas -= cost6;
            unitUpGrade(5, normaltype6, magictype6, raretype6, uniquetype6, epictype6);
            InunitUpHrade(normaltype6, magictype6, raretype6, uniquetype6, epictype6, UnitType.Type6);
            cost6 += 1;
        }
    }
    public void unitUpGrade7()
    {
        if (PG.CurrentGas >= cost7)
        {
            PG.CurrentGas -= cost7;
            unitUpGrade(6, normaltype7, magictype7, raretype7, uniquetype7, epictype7);
            InunitUpHrade(normaltype7, magictype7, raretype7, uniquetype7, epictype7, UnitType.Type7);
            cost7 += 1;
        }
    }
    public void unitUpGrade8()
    {
        if (PG.CurrentGas >= cost8)
        {
            PG.CurrentGas -= cost8;
            unitUpGrade(7, normaltype8, magictype8, raretype8, uniquetype8, epictype8);
            InunitUpHrade(normaltype8, magictype8, raretype8, uniquetype8, epictype8, UnitType.Type8);
            cost8 += 1;
        }
    }

    public void unitUpGrade(int i, float a, float b, float c, float d, float e)
    {
        US.unit1Prefab[i].GetComponent<UnitWeapon>().PowerUP(a);
        US.unit2Prefab[i].GetComponent<UnitWeapon>().PowerUP(b);
        US.unit3Prefab[i].GetComponent<UnitWeapon>().PowerUP(c);
        US.unit4Prefab[i].GetComponent<UnitWeapon>().PowerUP(d);
        US.unit5Prefab[i].GetComponent<UnitWeapon>().PowerUP(e);
    }

    public void InunitUpHrade(float a, float b, float c, float d, float e, UnitType unitType)
    {
        for (int i = 0; i < US.unit1.Count; i++)
        {
            if (US.unit1[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                GameObject clone = Instantiate(effect, US.unit1[i].transform.position, Quaternion.identity);
                Vector3 EffectPos = clone.transform.position;
                EffectPos.y += 0.1f;
                clone.transform.position = EffectPos;
                US.unit1[i].GetComponent<UnitWeapon>().PowerUP(a);
            }
        }
        for (int i = 0; i < US.unit2.Count; i++)
        {
            if (US.unit2[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                GameObject clone = Instantiate(effect, US.unit2[i].transform.position, Quaternion.identity);
                Vector3 EffectPos = clone.transform.position;
                EffectPos.y += 0.1f;
                clone.transform.position = EffectPos;
                US.unit2[i].GetComponent<UnitWeapon>().PowerUP(b);
            }
        }
        for (int i = 0; i < US.unit3.Count; i++)
        {
            if (US.unit3[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                GameObject clone = Instantiate(effect, US.unit3[i].transform.position, Quaternion.identity);
                Vector3 EffectPos = clone.transform.position;
                EffectPos.y += 0.1f;
                clone.transform.position = EffectPos;
                US.unit3[i].GetComponent<UnitWeapon>().PowerUP(c);
            }
        }
        for (int i = 0; i < US.unit4.Count; i++)
        {
            if (US.unit4[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                GameObject clone = Instantiate(effect, US.unit4[i].transform.position, Quaternion.identity);
                Vector3 EffectPos = clone.transform.position;
                EffectPos.y += 0.1f;
                clone.transform.position = EffectPos;
                US.unit4[i].GetComponent<UnitWeapon>().PowerUP(d);
            }
        }
        for (int i = 0; i < US.unit5.Count; i++)
        {
            if (US.unit5[i].GetComponent<UnitWeapon>().unitType == unitType)
            {
                GameObject clone = Instantiate(effect, US.unit5[i].transform.position, Quaternion.identity);
                Vector3 EffectPos = clone.transform.position;
                EffectPos.y += 0.1f;
                clone.transform.position = EffectPos;
                US.unit5[i].GetComponent<UnitWeapon>().PowerUP(e);
            }
        }
    }

    public void RandomGas()
    {
        if (PG.CurrentGold >= 100)
        {
            if (TOD != null)
            {
                if (TOD.tutorialCount == 25)
                {
                    TOD.TutorialPanel();
                }
            }
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
            if (TOD != null)
            {
                if (TOD.tutorialCount == 24)
                {
                    TOD.TutorialPanel();
                    PG.CurrentGold += 100;
                }
            }
            panel.SetActive(true);
            ispanel = true;
        }
        else
        {
            panel.SetActive(false);
            ispanel = false;
            if (TOD != null)
            {
                if (TOD.tutorialCount == 26)
                {
                    TOD.TutorialPanel();
                    WM.isStop = false;
                }
            }
        }
    }
}

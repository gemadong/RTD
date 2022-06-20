using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hidden : MonoBehaviour
{
    [SerializeField] private Setting setting;
    [SerializeField] private UnitSpawner US;
    [SerializeField] private PlayerGold PG;
    [SerializeField] private PlayerHP PH;
    [SerializeField] private Mission mission;
    [SerializeField] private Draw draw;
    [SerializeField] private UpGrade upGrade;
    [SerializeField] private GameObject panel;
    [SerializeField] private Text hidden1;
    [SerializeField] private Text hidden2;
    [SerializeField] private Text hidden3;
    [SerializeField] private Text hidden4;
    [SerializeField] private Text hidden5;
    [SerializeField] private Text hidden6;
    [SerializeField] private Text hidden7;
    [SerializeField] private Text hidden8;
    [SerializeField] private Text hidden9;

    public List<UnitWeapon> hiddenObj1;
    public List<UnitWeapon> hiddenObj2;
    public List<UnitWeapon> hiddenObj3;
    public List<UnitWeapon> hiddenObj4;
    public List<UnitWeapon> hiddenObj5;
    public List<UnitWeapon> hiddenObj7;
    public List<UnitWeapon> hiddenObj8;

    public bool ispanel = false;
    bool hiddenClear1 = false;
    bool hiddenClear2 = false;
    bool hiddenClear3= false;
    bool hiddenClear4 = false;
    bool hiddenClear5 = false;
    bool hiddenClear6 = false;
    bool hiddenClear7 = false;
    bool hiddenClear8 = false;
    bool hiddenClear9 = false;

    private void Update()
    {
        Hidden9();
    }


    public void Hidden1()
    {
        if (!hiddenClear1)
        {
            hiddenObj1.Clear();
            for(int i = 0;i< US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj1.Add(US.unit1[i]);
                    break;
                }
            }

            hidden1.text = hiddenObj1.Count.ToString() + " / 8";
            if (hiddenObj1.Count == 8)
            {
                PG.CurrentGold += 300;
                HiddenClear(hidden1);
                hiddenObj1.Clear();
                hiddenClear1 = true;
            }
        }
        
    }

    public void Hidden2()
    {
        if (!hiddenClear2)
        {
            hiddenObj2.Clear();
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj2.Add(US.unit1[i]);
                }
            }
            hidden2.text = hiddenObj2.Count.ToString() + " / 7";
            if (hiddenObj2.Count == 7)
            {
                PG.CurrentGold += 400;
                HiddenClear(hidden2);
                hiddenObj2.Clear();
                hiddenClear2 = true;
            }

        }
    }

    public void Hidden3()
    {
        if (!hiddenClear3)
        {
            hiddenObj3.Clear();
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj3.Add(US.unit2[i]);
                    break;
                }
            }

            hidden3.text = hiddenObj3.Count.ToString() + " / 8";

            if (hiddenObj3.Count == 8)
            {
                PG.CurrentGold += 300;
                PG.CurrentGas += 100;
                HiddenClear(hidden3);
                hiddenObj3.Clear();
                hiddenClear3 = true;
            }
        }

    }

    public void Hidden4()
    {
        if (!hiddenClear4)
        {
            hiddenObj4.Clear();
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj4.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj4.Add(US.unit2[i]);
                    break;
                }
            }

            hidden4.text = hiddenObj4.Count.ToString() + " / 2";
            if (hiddenObj4.Count == 2)
            {
                PG.CurrentGold += 400;
                HiddenClear(hidden4);
                hiddenObj4.Clear();
                hiddenClear4 = true;
            }
        }
    }

    public void Hidden5()
    {
        if (!hiddenClear5)
        {
            hiddenObj5.Clear();
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj5.Add(US.unit2[i]);
                }
            }

            hidden5.text = hiddenObj5.Count.ToString() + " / 7";

            if (hiddenObj5.Count == 7)
            {
                draw.draw += 2;
                HiddenClear(hidden5);
                hiddenObj5.Clear();
                hiddenClear5 = true;
            }
        }
    }

    public void Hidden6()
    {
        if (!hiddenClear6)
        {
            hidden6.text = US.unit4.Count.ToString() + " / 6";
            if (US.unit4.Count == 6)
            {
                PG.CurrentGold += 300;
                HiddenClear(hidden6);
                hiddenClear6 = true;
            }
        }
    }

    public void Hidden7()
    {
        if (!hiddenClear7)
        {
            if (!hiddenClear7)
            {
                hiddenObj7.Clear();
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }
                for (int i = 0; i < US.unit4.Count; i++)
                {
                    if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                    {
                        hiddenObj7.Add(US.unit4[i]);
                        break;
                    }
                }

                hidden7.text = hiddenObj7.Count.ToString() + " / 7";
                if (hiddenObj7.Count == 7)
                {
                    draw.draw += 3;
                    HiddenClear(hidden7);
                    hiddenObj7.Clear();
                    hiddenClear7 = true;
                }
            }
        }
    }

    public void Hidden8()
    {
        if (!hiddenClear8)
        {
            hiddenObj8.Clear();
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj8.Add(US.unit4[i]);
                }
            }
            hidden8.text = hiddenObj8.Count.ToString() + " / 3";
            if (hiddenObj8.Count == 3)
            {
                PG.CurrentGold += 400;
                PG.CurrentGas += 400;
                HiddenClear(hidden8);
                hiddenObj8.Clear();
                hiddenClear8 = true;
            }

        }
    }

    public void Hidden9()
    {
        if (!hiddenClear9)
        {
            hidden9.text = PH.CurrentHP.ToString() + " / 10";
            if (PH.CurrentHP<=10)
            {
                PG.CurrentGas += 400;
                HiddenClear(hidden9);
                hiddenClear9 = true;
            }
        }
    }

    public void HiddenClear(Text text)
    {
        text.color = Color.red;
        text.text = "¼º°ø";
    }

    public void IsPanel()
    {
        if (!ispanel)
        {
            if (mission.ispanel == true) mission.IsPanel();
            if (upGrade.ispanel == true) upGrade.IsPanel();
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

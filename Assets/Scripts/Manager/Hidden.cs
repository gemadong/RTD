using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hidden : MonoBehaviour
{
    [SerializeField] private Setting setting;
    [SerializeField] private UnitSpawner US;
    [SerializeField] private EnemySpawner ES;
    [SerializeField] private PlayerGold PG;
    [SerializeField] private PlayerHP PH;
    [SerializeField] private Mission mission;
    [SerializeField] private Draw draw;
    [SerializeField] private UpGrade upGrade;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject botton;
    [SerializeField] private Text hidden1;
    [SerializeField] private Text hidden2;
    [SerializeField] private Text hidden3;
    [SerializeField] private Text hidden4;
    [SerializeField] private Text hidden5;
    [SerializeField] private Text hidden6;
    [SerializeField] private Text hidden7;
    [SerializeField] private Text hidden8;
    [SerializeField] private Text hidden9;
    [SerializeField] private Text hidden10;
    [SerializeField] private Text hidden11;
    [SerializeField] private Text hidden12;
    [SerializeField] private Text hidden13;
    [SerializeField] private Text hidden14;
    [SerializeField] private Text hidden15;
    [SerializeField] private Text hidden16;
    [SerializeField] private Text hidden17;
    [SerializeField] private Text hidden18;
    [SerializeField] private Text hidden19;
    [SerializeField] private Text hidden20;
    [SerializeField] private Text hidden21;
    [SerializeField] private Text hidden22;

    public List<UnitWeapon> hiddenObj1;
    public List<UnitWeapon> hiddenObj2;
    public List<UnitWeapon> hiddenObj3;
    public List<UnitWeapon> hiddenObj4;
    public List<UnitWeapon> hiddenObj5;
    public List<UnitWeapon> hiddenObj7;
    public List<UnitWeapon> hiddenObj8;
    public List<UnitWeapon> hiddenObj10;
    public List<UnitWeapon> hiddenObj11;
    public List<UnitWeapon> hiddenObj12;
    public List<UnitWeapon> hiddenObj13;
    public List<UnitWeapon> hiddenObj14;
    public List<UnitWeapon> hiddenObj15;
    public List<UnitWeapon> hiddenObj16;
    public List<UnitWeapon> hiddenObj17;
    public List<UnitWeapon> hiddenObj19;
    public List<UnitWeapon> hiddenObj20;
    public List<UnitWeapon> hiddenObj21;
    public List<UnitWeapon> hiddenObj22;

    public bool ispanel = false;

    bool killhiddenClear1 = false;
    bool killhiddenClear2 = false;
    bool killhiddenClear3 = false;
    bool hiddenClear1 = false;
    bool hiddenClear2 = false;
    bool hiddenClear3= false;
    bool hiddenClear4 = false;
    bool hiddenClear5 = false;
    bool hiddenClear6 = false;
    bool hiddenClear7 = false;
    bool hiddenClear8 = false;
    bool hiddenClear9 = false;
    bool hiddenClear10 = false;
    bool hiddenClear11 = false;
    bool hiddenClear12 = false;
    bool hiddenClear13 = false;
    bool hiddenClear14 = false;
    bool hiddenClear15 = false;
    bool hiddenClear16 = false;
    bool hiddenClear17 = false;
    bool hiddenClear18 = false;
    bool hiddenClear19 = false;
    bool hiddenClear20 = false;
    bool hiddenClear21 = false;
    bool hiddenClear22 = false;



    private void Update()
    {
        Hidden9();
        Hidden18();
        KillHidden();
    }

    private void Start()
    {
        Hidden1();
        Hidden2();
        Hidden3();
        Hidden4();
        Hidden5();
        Hidden6();
        Hidden7();
        Hidden8();
        Hidden9();
        Hidden10();
        Hidden11();
        Hidden12();
        Hidden13();
        Hidden14();
        Hidden15();
        Hidden16();
        Hidden17();
        Hidden19();
        Hidden20();
        Hidden21();
        Hidden22();
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
                StartCoroutine("HiddenClearBotten");
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
                StartCoroutine("HiddenClearBotten");
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
                StartCoroutine("HiddenClearBotten");
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
                StartCoroutine("HiddenClearBotten");
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
                StartCoroutine("HiddenClearBotten");
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
                StartCoroutine("HiddenClearBotten");
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
                    StartCoroutine("HiddenClearBotten");
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
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
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
                StartCoroutine("HiddenClearBotten");
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
                StartCoroutine("HiddenClearBotten");
                hiddenClear9 = true;
            }
        }
    }

    public void Hidden10()
    {
        if (!hiddenClear10)
        {
            hiddenObj10.Clear();
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj10.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
                {
                    hiddenObj10.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj10.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj10.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj10.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj10.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj10.Add(US.unit4[i]);
                    break;
                }
            }

            hidden10.text = hiddenObj10.Count.ToString() + " / 7";
            if (hiddenObj10.Count == 7)
            {
                draw.draw += 3;
                HiddenClear(hidden10);
                hiddenObj10.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear10 = true;
            }
        }

    }

    public void Hidden11()
    {
        if (!hiddenClear11)
        {
            hiddenObj11.Clear();
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj11.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj11.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj11.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj11.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj11.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj11.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj11.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj11.Add(US.unit4[i]);
                    break;
                }
            }

            hidden11.text = hiddenObj11.Count.ToString() + " / 8";
            if (hiddenObj11.Count == 8)
            {
                draw.unique += 1;
                HiddenClear(hidden11);
                hiddenObj11.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear11 = true;
            }
        }
    }

    public void Hidden12()
    {
        if (!hiddenClear12)
        {
            hiddenObj12.Clear();
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj12.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj12.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj12.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj12.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
                {
                    hiddenObj12.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj12.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj12.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj12.Add(US.unit4[i]);
                    break;
                }
            }

            hidden12.text = hiddenObj12.Count.ToString() + " / 8";
            if (hiddenObj12.Count == 8)
            {
                draw.unique += 1;
                HiddenClear(hidden12);
                hiddenObj12.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear12 = true;
            }
        }
    }

    public void Hidden13()
    {
        if (!hiddenClear13)
        {
            hiddenObj13.Clear();
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj13.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj13.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj13.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj13.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj13.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj13.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj13.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj13.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj13.Add(US.unit4[i]);
                    break;
                }
            }

            hidden13.text = hiddenObj13.Count.ToString() + " / 9";
            if (hiddenObj13.Count == 9)
            {
                draw.draw += 2;
                HiddenClear(hidden13);
                hiddenObj13.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear13 = true;
            }
        }
    }

    public void Hidden14()
    {
        if (!hiddenClear14)
        {
            hiddenObj14.Clear();
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj14.Add(US.unit2[i]);

                    a++;
                    if(a==3) break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj14.Add(US.unit2[i]);
                    b++;
                    if (b == 3) break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj14.Add(US.unit3[i]);
                    c++;
                    if (c == 3) break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj14.Add(US.unit3[i]);
                    d++;
                    if (d == 3) break;
                }
            }
            hidden14.text = hiddenObj14.Count.ToString() + " / 12";
            if (hiddenObj14.Count == 12)
            {
                draw.rare += 2;
                HiddenClear(hidden14);
                hiddenObj14.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear14 = true;
            }
        }
    }

    public void Hidden15()
    {
        if (!hiddenClear15)
        {
            hiddenObj15.Clear();
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj15.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj15.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj15.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj15.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj15.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj15.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj15.Add(US.unit4[i]);
                    break;
                }
            }

            hidden15.text = hiddenObj15.Count.ToString() + " / 7";
            if (hiddenObj15.Count == 7)
            {
                draw.draw += 1;
                HiddenClear(hidden15);
                hiddenObj15.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear15 = true;
            }
        }
    }

    public void Hidden16()
    {
        if (!hiddenClear16)
        {
            hiddenObj16.Clear();
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj16.Add(US.unit4[i]);

                    a++;
                    if (a == 3) break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj16.Add(US.unit3[i]);
                    c++;
                    if (c == 3) break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type4)
                {
                    hiddenObj16.Add(US.unit3[i]);
                    b++;
                    if (b == 3) break;
                }
            }
            hidden16.text = hiddenObj16.Count.ToString() + " / 9";
            if (hiddenObj16.Count == 9)
            {
                draw.epic += 1;
                HiddenClear(hidden16);
                hiddenObj16.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear16 = true;
            }
        }
    }

    public void Hidden17()
    {
        if (!hiddenClear17)
        {
            hiddenObj17.Clear();
            for (int i = 0; i < US.unit5.Count; i++)
            {
                if (US.unit5[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
                {
                    hiddenObj17.Add(US.unit5[i]);
                }
            }
            hidden17.text = hiddenObj17.Count.ToString() + " / 3";
            if (hiddenObj17.Count == 3)
            {
                draw.unique += 2;
                HiddenClear(hidden17);
                hiddenObj17.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear17 = true;
            }

        }
    }

    public void Hidden18()
    {
        if (!hiddenClear18)
        {
            hidden18.text = draw.draw + " / 5";
            if (draw.draw >= 5)
            {
                draw.unique += 1;
                HiddenClear(hidden18);
                StartCoroutine("HiddenClearBotten");
                hiddenClear18 = true;
            }

        }
    }

    public void Hidden19()
    {
        if (!hiddenClear19)
        {
            hiddenObj19.Clear();
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj19.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj19.Add(US.unit1[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj19.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj19.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type7)
                {
                    hiddenObj19.Add(US.unit2[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj19.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type2)
                {
                    hiddenObj19.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj19.Add(US.unit3[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj19.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj19.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (US.unit4[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj19.Add(US.unit4[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit5.Count; i++)
            {
                if (US.unit5[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj19.Add(US.unit5[i]);
                    break;
                }
            }
            for (int i = 0; i < US.unit5.Count; i++)
            {
                if (US.unit5[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj19.Add(US.unit5[i]);
                    break;
                }
            }

            hidden19.text = hiddenObj19.Count.ToString() + " / 13";
            if (hiddenObj19.Count == 13)
            {
                draw.epic += 1;
                PG.CurrentGold += 1000;
                PG.CurrentGas += 4;
                HiddenClear(hidden19);
                hiddenObj19.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear19 = true;
            }
        }
    }

    public void Hidden20()
    {
        if (!hiddenClear20)
        {
            hiddenObj20.Clear();
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj20.Add(US.unit1[i]);
                    a++;
                    if (a >= 3) break;
                }
            }
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (US.unit1[i].GetComponent<UnitWeapon>().unitType == UnitType.Type3)
                {
                    hiddenObj20.Add(US.unit1[i]);
                    b++;
                    if (b >= 3) break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type6)
                {
                    hiddenObj20.Add(US.unit3[i]);
                    c++;
                    if (c >= 3) break;
                }
            }
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type8)
                {
                    hiddenObj20.Add(US.unit3[i]);
                    d++;
                    if (d >= 3) break;
                }
            }
            hidden20.text = hiddenObj20.Count.ToString() + " / 12";
            if (hiddenObj20.Count == 12)
            {
                PH.DMG(-6f);
                HiddenClear(hidden20);
                hiddenObj20.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear20 = true;
            }
        }
    }

    public void Hidden21()
    {
        if (!hiddenClear21)
        {
            hiddenObj21.Clear();
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (US.unit3[i].GetComponent<UnitWeapon>().unitType == UnitType.Type5)
                {
                    hiddenObj21.Add(US.unit3[i]);
                }
            }
            hidden21.text = hiddenObj21.Count.ToString() + " / 5";
            if (hiddenObj21.Count == 5)
            {
                draw.draw += 3;
                draw.unique += 1;
                HiddenClear(hidden21);
                hiddenObj21.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear21 = true;
            }

        }
    }

    public void Hidden22()
    {
        if (!hiddenClear22)
        {
            hiddenObj22.Clear();
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (US.unit2[i].GetComponent<UnitWeapon>().unitType == UnitType.Type1)
                {
                    hiddenObj22.Add(US.unit2[i]);
                }
            }
            hidden22.text = hiddenObj22.Count.ToString() + " / 7";
            if (hiddenObj22.Count == 7)
            {
                draw.unique += 1;
                HiddenClear(hidden22);
                hiddenObj22.Clear();
                StartCoroutine("HiddenClearBotten");
                hiddenClear22 = true;
            }

        }
    }

    public void KillHidden()
    {
        if (!killhiddenClear1)
        {
            if(ES.killCount >= 250)
            {
                PG.CurrentGold += 200;
                killhiddenClear1 = true;
            }
        }
        if (!killhiddenClear2)
        {
            if (ES.killCount >= 500)
            {
                PG.CurrentGold += 300;
                killhiddenClear2 = true;
            }
        }
        if (!killhiddenClear3)
        {
            if (ES.killCount >= 750)
            {
                PG.CurrentGold += 400;
                killhiddenClear3 = true;
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

    IEnumerator HiddenClearBotten()
    {
        Color reColor = botton.GetComponent<Image>().color;
        botton.GetComponent<Image>().color = Color.yellow;
        yield return new WaitForSeconds(0.2f);
        botton.GetComponent<Image>().color = reColor;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hidden : MonoBehaviour
{
    [SerializeField] private UnitSpawner US;
    [SerializeField] private Mission mission;
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

            if(hiddenObj1.Count == 8)
            {
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
            if (hiddenObj2.Count == 7)
            {
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

            if (hiddenObj3.Count == 8)
            {
                HiddenClear(hidden3);
                hiddenObj3.Clear();
                hiddenClear3 = true;
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

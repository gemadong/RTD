using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpGrade : MonoBehaviour
{
    [SerializeField] private Mission mission;
    [SerializeField] private Hidden hidden;
    [SerializeField] private GameObject panel;
    [SerializeField] private UnitSpawner US;

    public bool ispanel = false;

    public void unitUpGrade1()
    {
        unitUpGrade(0,10f);
    }
    public void unitUpGrade2()
    {
        unitUpGrade(1, 10f);
    }
    public void unitUpGrade3()
    {
        unitUpGrade(2, 10f);
    }
    public void unitUpGrade4()
    {
        unitUpGrade(3, 10f);
    }
    public void unitUpGrade5()
    {
        unitUpGrade(4, 10f);
    }
    public void unitUpGrade6()
    {
        unitUpGrade(5, 10f);
    }
    public void unitUpGrade7()
    {
        unitUpGrade(6, 10f);
    }
    public void unitUpGrade8()
    {
        unitUpGrade(7, 10f);
    }
    public void unitUpGrade9()
    {
        unitUpGrade(8, 10f);
    }

    public void unitUpGrade(int i, float j)
    {
        US.unit1Prefab[i].GetComponent<UnitWeapon>().power += j;
        US.unit2Prefab[i].GetComponent<UnitWeapon>().power += j;
        US.unit3Prefab[i].GetComponent<UnitWeapon>().power += j;
        US.unit4Prefab[i].GetComponent<UnitWeapon>().power += j;
        US.unit5Prefab[i].GetComponent<UnitWeapon>().power += j;
    }
    public void IsPanel()
    {
        if (!ispanel)
        {
            if (mission.ispanel == true) mission.IsPanel();
            if (hidden.ispanel == true) hidden.IsPanel();
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

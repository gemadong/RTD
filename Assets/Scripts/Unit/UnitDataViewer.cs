using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitDataViewer : MonoBehaviour
{
    [SerializeField] private UnitSpawner US;
    [SerializeField] private Text DMGtext;
    [SerializeField] private Text Ratetext;
    [SerializeField] private Text Rangetext;
    [SerializeField] private Text Leveltext;
    [SerializeField] private GameObject UnitPos;

    [SerializeField] private AttackRange AR;

    private UnitWeapon currentUnit;
    private UnitWeapon clone;

    private void Awake()
    {
        OffPane1();
    }
    public void OnPane1(Transform unitWeapon)
    {
        currentUnit = unitWeapon.GetComponent<UnitWeapon>();
        clone = Instantiate(currentUnit, UnitPos.transform.position, Quaternion.identity);
        gameObject.SetActive(true);
        UpdateUnitDate();
        AR.OnAttackRange(currentUnit.transform.position, currentUnit.Range);
        Find();
    }
    public void OffPane1()
    {
        if(clone != null) Destroy(clone.gameObject);
        if (currentUnit != null) Find();
        AR.OffAttackRange();
        gameObject.SetActive(false);
        currentUnit = null;
    }
    private void UpdateUnitDate()
    {
        DMGtext.text = "������ : " + currentUnit.Damage+" (+" + currentUnit.upGrade+")";
        Ratetext.text = "���ݼӵ� : " + currentUnit.Rate;
        Rangetext.text = "��Ÿ� : " + currentUnit.Range;
        if (currentUnit.unitValue == UnitValue.Value1) Leveltext.text = "��� : �Ϲ�";
        if (currentUnit.unitValue == UnitValue.Value2) Leveltext.text = "��� : ����";
        if (currentUnit.unitValue == UnitValue.Value3) Leveltext.text = "��� : ����";
        if (currentUnit.unitValue == UnitValue.Value4) Leveltext.text = "��� : ����ũ";
        if (currentUnit.unitValue == UnitValue.Value5) Leveltext.text = "��� : ����";
    }
    private void Find()
    {
        if (currentUnit.unitValue == UnitValue.Value1)
        {
            for (int i = 0; i < US.unit1.Count; i++)
            {
                if (currentUnit.unitType == US.unit1[i].unitType) US.unit1[i].Check();
            }
        }
        else if (currentUnit.unitValue == UnitValue.Value2)
        {
            for (int i = 0; i < US.unit2.Count; i++)
            {
                if (currentUnit.unitType == US.unit2[i].unitType) US.unit2[i].Check();
            }
        }
        else if (currentUnit.unitValue == UnitValue.Value3)
        {
            for (int i = 0; i < US.unit3.Count; i++)
            {
                if (currentUnit.unitType == US.unit3[i].unitType) US.unit3[i].Check();
            }
        }
        else if (currentUnit.unitValue == UnitValue.Value4)
        {
            for (int i = 0; i < US.unit4.Count; i++)
            {
                if (currentUnit.unitType == US.unit4[i].unitType) US.unit4[i].Check();
            }
        }
        else if (currentUnit.unitValue == UnitValue.Value5)
        {
            for (int i = 0; i < US.unit5.Count; i++)
            {
                if (currentUnit.unitType == US.unit5[i].unitType) US.unit5[i].Check();
            }
        }


    }


}
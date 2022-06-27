using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitDataViewer : MonoBehaviour
{
    [SerializeField] private Text DMGtext;
    [SerializeField] private Text Ratetext;
    [SerializeField] private Text Rangetext;
    [SerializeField] private Text Leveltext;

    [SerializeField] private AttackRange AR;

    private UnitWeapon currentUnit;

    private void Awake()
    {
        OffPane1();
    }
    public void OnPane1(Transform unitWeapon)
    {
        currentUnit = unitWeapon.GetComponent<UnitWeapon>();
        gameObject.SetActive(true);
        UpdateUnitDate();
        AR.OnAttackRange(currentUnit.transform.position, currentUnit.Range);
    }
    public void OffPane1()
    {
        AR.OffAttackRange();
        gameObject.SetActive(false);
    }
    private void UpdateUnitDate()
    {
        DMGtext.text = "Damage : " + currentUnit.Damage;
        Ratetext.text = "Rate : " + currentUnit.Rate;
        Rangetext.text = "Range : " + currentUnit.Range;
        Leveltext.text = "Level : " + currentUnit.Level;
    }

}

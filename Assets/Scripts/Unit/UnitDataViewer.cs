using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitDataViewer : MonoBehaviour
{
    [SerializeField] private Image imageUnit;
    [SerializeField] private Text DMGtext;
    [SerializeField] private Text Ratetext;
    [SerializeField] private Text Rangetext;
    [SerializeField] private Text Leveltext;

    private UnitWeapon currentUnit;

    private void Awake()
    {
        OffPane1();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OffPane1();
        }
    }
    public void OnPane1(Transform unitWeapon)
    {
        currentUnit = unitWeapon.GetComponent<UnitWeapon>();
        gameObject.SetActive(true);
        UpdateUnitDate();
    }
    public void OffPane1()
    {
        gameObject.SetActive(false);
    }
    private void UpdateUnitDate()
    {
        imageUnit.sprite = currentUnit.imageUnit;
        imageUnit.color = currentUnit.color;
        DMGtext.text = "Damage : " + currentUnit.Damage;
        Ratetext.text = "Rate : " + currentUnit.Rate;
        Rangetext.text = "Range : " + currentUnit.Range;
        Leveltext.text = "Level : " + currentUnit.Level;
    }

}

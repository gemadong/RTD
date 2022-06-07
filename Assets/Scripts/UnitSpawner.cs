using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    [SerializeField] private UnitWeapon[] unit1Prefab;
    [SerializeField] private UnitWeapon[] unit2Prefab;
    [SerializeField] private UnitWeapon[] unit3Prefab;
    [SerializeField] private UnitWeapon[] unit4Prefab;
    [SerializeField] private UnitWeapon[] unit5Prefab;
    [SerializeField] private EnemySpawner ES;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private int unitBuildGold = 100;

    #region unit 중복 검사
    public List<UnitWeapon> unit1Lv1;
    public List<UnitWeapon> unit1Lv2;
    public List<UnitWeapon> unit1Lv3;
    public List<UnitWeapon> unit1Lv4;
    public List<UnitWeapon> unit1Lv5;
    public List<UnitWeapon> unit2Lv1;
    public List<UnitWeapon> unit2Lv2;
    public List<UnitWeapon> unit2Lv3;
    public List<UnitWeapon> unit2Lv4;
    public List<UnitWeapon> unit2Lv5;
    public List<UnitWeapon> unit3Lv1;
    public List<UnitWeapon> unit3Lv2;
    public List<UnitWeapon> unit3Lv3;
    public List<UnitWeapon> unit3Lv4;
    public List<UnitWeapon> unit3Lv5;
    public List<UnitWeapon> unit4Lv1;
    public List<UnitWeapon> unit4Lv2;
    public List<UnitWeapon> unit4Lv3;
    public List<UnitWeapon> unit4Lv4;
    public List<UnitWeapon> unit4Lv5;
    public List<UnitWeapon> unit5Lv1;
    public List<UnitWeapon> unit5Lv2;
    public List<UnitWeapon> unit5Lv3;
    public List<UnitWeapon> unit5Lv4;
    public List<UnitWeapon> unit5Lv5;
    public List<UnitWeapon> unit6Lv1;
    public List<UnitWeapon> unit6Lv2;
    public List<UnitWeapon> unit6Lv3;
    public List<UnitWeapon> unit6Lv4;
    public List<UnitWeapon> unit6Lv5;
    public List<UnitWeapon> unit7Lv1;
    public List<UnitWeapon> unit7Lv2;
    public List<UnitWeapon> unit7Lv3;
    public List<UnitWeapon> unit7Lv4;
    public List<UnitWeapon> unit7Lv5;
    public List<UnitWeapon> unit8Lv1;
    public List<UnitWeapon> unit8Lv2;
    public List<UnitWeapon> unit8Lv3;
    public List<UnitWeapon> unit8Lv4;
    public List<UnitWeapon> unit8Lv5;
    #endregion

    private Vector3 Pos;
    private Color ReColor = new Color(0.84f, 0.84f, 0.84f);

    

    private List<UnitWeapon> currentUnit1;

    public void SpawnUnit(Transform tileTransform)
    {
        if (unitBuildGold > playerGold.CurrentGold) return;

        Tile tile = tileTransform.GetComponent<Tile>();

        if (tile.IsBuildUnit == true) return;

        tile.IsBuildUnit = true;

        playerGold.CurrentGold -= unitBuildGold;
        Pos = tileTransform.position - new Vector3(0, 0, 2f);
        int a = Random.Range(0, unit1Prefab.Length);
        UnitWeapon clone = Instantiate(unit1Prefab[a], Pos, Quaternion.identity);
        clone.GetComponent<UnitWeapon>().Setup(ES);
        clone.GetComponent<UnitWeapon>().currentTile = tile;
        FindUnit(a, clone);
        tile.SR.color = new Color(1f, 0.72f, 0.73f);
    }
    void FindUnit(int i, UnitWeapon clone)
    {
        if (i == 0) unit1Lv1.Add(clone);
        else if (i == 1) unit2Lv1.Add(clone);
        else if (i == 2) unit3Lv1.Add(clone);
        else if (i == 3) unit4Lv1.Add(clone);
        else if (i == 4) unit5Lv1.Add(clone);
        else if (i == 5) unit6Lv1.Add(clone);
        else if (i == 6) unit7Lv1.Add(clone);
        else if (i == 7) unit8Lv1.Add(clone);
    }
    private void SpawnUnit2(Transform tileTransform)
    {
        if (unitBuildGold > playerGold.CurrentGold) return;

        Tile tile = tileTransform.GetComponent<Tile>();

        if (tile.IsBuildUnit == true) return;

        tile.IsBuildUnit = true;

        playerGold.CurrentGold -= unitBuildGold;
        Pos = tileTransform.position - new Vector3(0, 0, 2f);
        int a = Random.Range(0, unit1Prefab.Length);
        UnitWeapon clone = Instantiate(unit1Prefab[a], Pos, Quaternion.identity);
        clone.GetComponent<UnitWeapon>().Setup(ES);
        clone.GetComponent<UnitWeapon>().currentTile = tile;
        currentUnit1.Add(clone);
        tile.SR.color = new Color(1f, 0.72f, 0.73f);
    }

}

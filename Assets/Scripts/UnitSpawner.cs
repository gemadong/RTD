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
    Vector3 Pos;

    

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
        currentUnit1.Add(clone);
        tile.SR.color = new Color(1f, 0.72f, 0.73f);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject unit1Prefab;
    [SerializeField] private GameObject unit2Prefab;
    [SerializeField] private EnemySpawner ES;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private int unitBuildGold = 100;
    Vector3 Pos;

    public void SpawnUnit(Transform tileTransform)
    {
        if (unitBuildGold > playerGold.CurrentGold) return;

        Tile tile = tileTransform.GetComponent<Tile>();

        if (tile.IsBuildUnit == true) return;

        tile.IsBuildUnit = true;

        playerGold.CurrentGold -= unitBuildGold;
        Pos = tileTransform.position - new Vector3(0, 0, 2f);
        GameObject clone = Instantiate(unit1Prefab, Pos, Quaternion.identity);
        clone.GetComponent<UnitWeapon>().Setup(ES);
    }

}

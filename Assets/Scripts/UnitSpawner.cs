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

    public int Num;

    public List<UnitWeapon> unit1;
    public List<UnitWeapon> unit2;
    public List<UnitWeapon> unit3;
    public List<UnitWeapon> unit4;
    public List<UnitWeapon> unit5;
    

    private Vector3 Pos;
    private Color ReColor = new Color(0.84f, 0.84f, 0.84f);

    public bool merge = false;


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
        unit1.Add(clone);
        tile.SR.color = new Color(1f, 0.72f, 0.73f);
    }
    public void SpawnUnit2(Transform tileTransform)
    {
        UnitReMove(unit1);
        Tile tile = tileTransform.GetComponent<Tile>();

        Pos = tileTransform.position - new Vector3(0, 0, 2f);
        int a = Random.Range(0, unit2Prefab.Length);
        UnitWeapon clone = Instantiate(unit2Prefab[a], Pos, Quaternion.identity);
        clone.GetComponent<UnitWeapon>().Setup(ES);
        clone.GetComponent<UnitWeapon>().currentTile = tile;
        unit2.Add(clone);
        tile.SR.color = new Color(1f, 1f, 0.73f);
    }
    public void SpawnUnit3(Transform tileTransform)
    {
        UnitReMove(unit2);
        Tile tile = tileTransform.GetComponent<Tile>();

        Pos = tileTransform.position - new Vector3(0, 0, 2f);
        int a = Random.Range(0, unit3Prefab.Length);
        UnitWeapon clone = Instantiate(unit3Prefab[a], Pos, Quaternion.identity);
        clone.GetComponent<UnitWeapon>().Setup(ES);
        clone.GetComponent<UnitWeapon>().currentTile = tile;
        unit3.Add(clone);
        tile.SR.color = new Color(0.72f, 1f, 0.72f);
    }
    public void SpawnUnit4(Transform tileTransform)
    {
        UnitReMove(unit3);
        Tile tile = tileTransform.GetComponent<Tile>();

        Pos = tileTransform.position - new Vector3(0, 0, 2f);
        int a = Random.Range(0, unit4Prefab.Length);
        UnitWeapon clone = Instantiate(unit4Prefab[a], Pos, Quaternion.identity);
        clone.GetComponent<UnitWeapon>().Setup(ES);
        clone.GetComponent<UnitWeapon>().currentTile = tile;
        unit4.Add(clone);
        tile.SR.color = new Color(0.72f, 0.8f, 1f);
    }
    public void SpawnUnit5(Transform tileTransform)
    {
        UnitReMove(unit4);
        Tile tile = tileTransform.GetComponent<Tile>();

        Pos = tileTransform.position - new Vector3(0, 0, 2f);
        int a = Random.Range(0, unit5Prefab.Length);
        UnitWeapon clone = Instantiate(unit5Prefab[a], Pos, Quaternion.identity);
        clone.GetComponent<UnitWeapon>().Setup(ES);
        clone.GetComponent<UnitWeapon>().currentTile = tile;
        unit5.Add(clone);
        tile.SR.color = new Color(0.88f, 0.72f, 1f);
    }

    public void  MergeUnit(UnitWeapon unitWeapon, List<UnitWeapon> unit)
    {
        for(int i = 0; i < unit.Count; i++)
        {
            if (unitWeapon != unit[i] && unitWeapon.unitType == unit[i].unitType)
            {
                merge = true;
                Num = i;
            }
        }
    }

    private void UnitReMove(List<UnitWeapon> unit)
    {
        unit[Num].currentTile.SR.color = unit[Num].currentTile.reColor;
        unit[Num].DestroyUnit();
        unit[Num].currentTile.IsBuildUnit = false;
        unit.Remove(unit[Num]);
    }
}

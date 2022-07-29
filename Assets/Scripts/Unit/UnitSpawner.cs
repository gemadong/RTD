using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ModeState
{
    MainMode,
    TutorialMode
}

public class UnitSpawner : MonoBehaviour
{
    [SerializeField] private EnemySpawner ES;
    [SerializeField] private ObjectDetector OD;
    [SerializeField] private TutorialObjectDetector TOD;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private Hidden hidden;
    [SerializeField] private int unitBuildGold = 100;
    [SerializeField] private ModeState modeState;


    public int Num;

    public UnitWeapon[] unit1Prefab;
    public UnitWeapon[] unit2Prefab;
    public UnitWeapon[] unit3Prefab;
    public UnitWeapon[] unit4Prefab;
    public UnitWeapon[] unit5Prefab;

    public List<UnitWeapon> unit1;
    public List<UnitWeapon> unit2;
    public List<UnitWeapon> unit3;
    public List<UnitWeapon> unit4;
    public List<UnitWeapon> unit5;


    public List<UnitWeapon> drawUnit;

    private Vector3 Pos;
    private Color ReColor = new Color(0.84f, 0.84f, 0.84f);

    public bool merge = false;
    public bool isdraw = false;
    
    
    private void Start()
    {
        if (modeState != ModeState.TutorialMode) 
        { 
            for(int i = 0; i < 8; i++)
            {
                unit1Prefab[i].reinforce = Singleton.instance.classCount[i] - 1;
                unit2Prefab[i].reinforce = Singleton.instance.classCount[i] - 1;
                unit3Prefab[i].reinforce = Singleton.instance.classCount[i] - 1;
                unit4Prefab[i].reinforce = Singleton.instance.classCount[i] - 1;
                unit5Prefab[i].reinforce = Singleton.instance.classCount[i] - 1;
            }
        }
    }

    public void SpawnUnit(Transform tileTransform)
    {
        if (unitBuildGold > playerGold.CurrentGold) return;
        
        Tile tile = tileTransform.GetComponent<Tile>();

        if (tile.IsBuildUnit == true) return;

        tile.IsBuildUnit = true;

        playerGold.CurrentGold -= unitBuildGold;
        Pos = tileTransform.position -new Vector3(0, 0f, 3.5f);

        if (isdraw)
        {
            UnitWeapon clone = Instantiate(drawUnit[0], Pos, Quaternion.identity);
            clone.GetComponent<UnitWeapon>().Setup(ES);
            clone.GetComponent<UnitWeapon>().currentTile = tile;
            if (drawUnit[0].GetComponent<UnitWeapon>().unitValue == UnitValue.Value3)
            {
                unit3.Add(clone);
                tile.SR.color = new Color(0.72f, 1f, 0.72f);
            }
            else if(drawUnit[0].GetComponent<UnitWeapon>().unitValue == UnitValue.Value4)
            {
                unit4.Add(clone);
                tile.SR.color = new Color(0.72f, 0.8f, 1f);
            }
            else if (drawUnit[0].GetComponent<UnitWeapon>().unitValue == UnitValue.Value5)
            {
                unit5.Add(clone);
                tile.SR.color = new Color(0.88f, 0.72f, 1f);
            }
            drawUnit.Remove(drawUnit[0]);
            if (drawUnit.Count == 0) isdraw = false;
        }
        else if(!isdraw)
        {
            int a = Random.Range(0, unit1Prefab.Length);
            UnitWeapon clone = Instantiate(unit1Prefab[a], Pos, Quaternion.identity);
            clone.GetComponent<UnitWeapon>().Setup(ES);
            clone.GetComponent<UnitWeapon>().currentTile = tile;
            unit1.Add(clone);
            tile.SR.color = new Color(1f, 0.72f, 0.73f);
        }
    }
    public void SpawnUnit2(Transform tileTransform)
    {
        UnitReMove(unit1);
        Tile tile = tileTransform.GetComponent<Tile>();

        Pos = tileTransform.position - new Vector3(0, 0, 3.5f);
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

        Pos = tileTransform.position - new Vector3(0, 0, 3.5f);
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

        Pos = tileTransform.position - new Vector3(0, 0, 3.5f);
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

        Pos = tileTransform.position - new Vector3(0, 0, 3.5f);
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

    public void UnitSelling()
    {
        if (TOD != null)
        {
            if (TOD.unitWeapon != null)
            {
                if (TOD.unitWeapon.unitValue == UnitValue.Value1)
                {
                    unit1.Remove(TOD.unitWeapon);
                    playerGold.CurrentGold += 50;
                }
                else if (TOD.unitWeapon.unitValue == UnitValue.Value2)
                {
                    unit2.Remove(TOD.unitWeapon);
                    playerGold.CurrentGold += 100;
                }
                else if (TOD.unitWeapon.unitValue == UnitValue.Value3)
                {
                    unit3.Remove(TOD.unitWeapon);
                    playerGold.CurrentGold += 200;
                }
                else if (TOD.unitWeapon.unitValue == UnitValue.Value4)
                {
                    unit4.Remove(TOD.unitWeapon);
                    playerGold.CurrentGold += 400;
                }
                else if (TOD.unitWeapon.unitValue == UnitValue.Value5)
                {
                    unit5.Remove(TOD.unitWeapon);
                    playerGold.CurrentGold += 800;
                }
                hidden.Hidden1();
                hidden.Hidden2();
                hidden.Hidden3();
                hidden.Hidden4();
                hidden.Hidden5();
                hidden.Hidden6();
                hidden.Hidden7();
                hidden.Hidden8();
                hidden.Hidden10();
                hidden.Hidden11();
                hidden.Hidden12();
                hidden.Hidden13();
                hidden.Hidden14();
                hidden.Hidden15();
                hidden.Hidden16();
                hidden.Hidden17();
                hidden.Hidden19();
                hidden.Hidden20();
                hidden.Hidden21();
                hidden.Hidden22();
                TOD.unitWeapon.currentTile.SR.color = TOD.unitWeapon.currentTile.reColor;
                TOD.unitWeapon.currentTile.IsCheck = false;
                TOD.unitWeapon.currentTile.IsBuildUnit = false;
                TOD.unitWeapon.DestroyUnit();
                TOD.IsCheckBlind = false;
                TOD.NoCheck();
            }
            if(TOD.tutorialCount==23) TOD.TutorialPanel();

            return;
        }

        if (OD.unitWeapon != null)
        {
            if (OD.unitWeapon.unitValue == UnitValue.Value1)
            {
                unit1.Remove(OD.unitWeapon);
                playerGold.CurrentGold += 50;
            }
            else if (OD.unitWeapon.unitValue == UnitValue.Value2)
            {
                unit2.Remove(OD.unitWeapon);
                playerGold.CurrentGold += 100;
            }
            else if (OD.unitWeapon.unitValue == UnitValue.Value3)
            {
                unit3.Remove(OD.unitWeapon);
                playerGold.CurrentGold += 200;
            }
            else if (OD.unitWeapon.unitValue == UnitValue.Value4)
            {
                unit4.Remove(OD.unitWeapon);
                playerGold.CurrentGold += 400;
            }
            else if (OD.unitWeapon.unitValue == UnitValue.Value5)
            {
                unit5.Remove(OD.unitWeapon);
                playerGold.CurrentGold += 800;
            }
            hidden.Hidden1();
            hidden.Hidden2();
            hidden.Hidden3();
            hidden.Hidden4();
            hidden.Hidden5();
            hidden.Hidden6();
            hidden.Hidden7();
            hidden.Hidden8();
            hidden.Hidden10();
            hidden.Hidden11();
            hidden.Hidden12();
            hidden.Hidden13();
            hidden.Hidden14();
            hidden.Hidden15();
            hidden.Hidden16();
            hidden.Hidden17();
            hidden.Hidden19();
            hidden.Hidden20();
            hidden.Hidden21();
            hidden.Hidden22();
            OD.unitWeapon.currentTile.SR.color = OD.unitWeapon.currentTile.reColor;
            OD.unitWeapon.currentTile.IsCheck = false;
            OD.unitWeapon.currentTile.IsBuildUnit = false;
            OD.unitWeapon.DestroyUnit();
            OD.IsCheckBlind = false;
            OD.NoCheck();
        }
    }
}

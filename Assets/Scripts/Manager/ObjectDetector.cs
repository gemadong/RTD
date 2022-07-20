using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] private UnitSpawner unitSpawner;
    [SerializeField] private UnitDataViewer UDV;
    [SerializeField] private Setting setting;
    [SerializeField] private Mission mission;
    [SerializeField] private Hidden hidden;
    [SerializeField] private UpGrade upGrade;
    [SerializeField] private Draw draw;

    private new Camera camera;
    private Ray ray;
    private RaycastHit hit;

    public bool IsCheckBlind = false;
    public bool Iswindow = false;
    public Tile tile;
    public UnitWeapon unitWeapon;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        if (mission.ispanel == true|| hidden.ispanel == true || upGrade.ispanel == true || draw.ispanel ==true || setting.ispanel == true) Iswindow = true;
        else if (mission.ispanel == false&& hidden.ispanel == false&& upGrade.ispanel == false && draw.ispanel == false && setting.ispanel == false) Iswindow = false;
        
        if (Iswindow && IsCheckBlind) NoCheck();

        if (Input.GetMouseButtonDown(0))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                

                if (hit.transform.CompareTag("UI")) return;

                if (Iswindow)
                {
                    if (mission.ispanel == true) mission.IsPanel();
                    if (hidden.ispanel == true) hidden.IsPanel();
                    if (upGrade.ispanel == true) upGrade.IsPanel();
                    if (draw.ispanel == true) draw.IsPanel();
                    if (setting.ispanel == true) setting.IsPanel();
                    return;
                }
                if (!IsCheckBlind)
                {
                    if (hit.transform.CompareTag("Tile"))
                    {
                        if (hit.transform.gameObject.GetComponent<Tile>().IsCheck == false)
                        {
                            tile = hit.transform.gameObject.GetComponent<Tile>();

                            if (tile.IsBuildUnit == true) return;
                            tile.IsCheck = true;
                            IsCheckBlind = true;
                        }
                    }
                    else if (hit.transform.CompareTag("Unit"))
                    {
                        UDV.OnPane1(hit.transform);
                        
                        unitWeapon = hit.transform.gameObject.GetComponent<UnitWeapon>();
                        tile = hit.transform.gameObject.GetComponent<UnitWeapon>().currentTile;
                        tile.IsCheck = true;
                        IsCheckBlind = true;
                    }
                }
                else
                {
                    if (hit.transform.CompareTag("Tile"))
                    {
                        if (hit.transform.gameObject == tile.gameObject)
                        {
                            unitSpawner.SpawnUnit(tile.transform);
                            NoCheck();
                        }
                        else
                        {
                            NoCheck();
                        }
                    }
                    else if (hit.transform.CompareTag("Unit"))
                    {
                        if (unitWeapon == null || hit.transform.gameObject != unitWeapon.gameObject)
                        {
                            NoCheck();
                            return;
                        }
                        if (hit.transform.gameObject == unitWeapon.gameObject)
                        {
                            if (unitWeapon.unitValue == UnitValue.Value1)
                            {
                                unitSpawner.MergeUnit(unitWeapon, unitSpawner.unit1);
                                if (unitSpawner.merge)
                                {
                                    unitSpawner.SpawnUnit2(tile.transform);
                                    unitWeapon.DestroyUnit();
                                    unitSpawner.unit1.Remove(unitWeapon);
                                    unitSpawner.merge = false;
                                }
                            }
                            else if (unitWeapon.unitValue == UnitValue.Value2)
                            {
                                unitSpawner.MergeUnit(unitWeapon, unitSpawner.unit2);
                                if (unitSpawner.merge)
                                {
                                    unitSpawner.SpawnUnit3(tile.transform);
                                    unitWeapon.DestroyUnit();
                                    unitSpawner.unit2.Remove(unitWeapon);
                                    unitSpawner.merge = false;
                                }
                            }
                            else if (unitWeapon.unitValue == UnitValue.Value3)
                            {
                                unitSpawner.MergeUnit(unitWeapon, unitSpawner.unit3);
                                if (unitSpawner.merge)
                                {
                                    unitSpawner.SpawnUnit4(tile.transform);
                                    unitWeapon.DestroyUnit();
                                    unitSpawner.unit3.Remove(unitWeapon);
                                    unitSpawner.merge = false;
                                }
                            }
                            else if (unitWeapon.unitValue == UnitValue.Value4)
                            {
                                unitSpawner.MergeUnit(unitWeapon, unitSpawner.unit4);
                                if (unitSpawner.merge)
                                {
                                    unitSpawner.SpawnUnit5(tile.transform);
                                    unitWeapon.DestroyUnit();
                                    unitSpawner.unit4.Remove(unitWeapon);
                                    unitSpawner.merge = false;

                                }
                            }
                            NoCheck();
                            unitWeapon = null;
                        }

                    }
                }
            }
            else NoCheck();

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
            hidden.Hidden22();
        }
    }

    public void NoCheck()
    {
        UDV.OffPane1();
        if(tile != null)
        {
            tile.IsCheck = false;
            tile = null;
        }
        IsCheckBlind = false;
        StartCoroutine("unitNull");

    }

    IEnumerator unitNull()
    {
        yield return new WaitForSeconds(0.1f);
        unitWeapon = null;
    }
}

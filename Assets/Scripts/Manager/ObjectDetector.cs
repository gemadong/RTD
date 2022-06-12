using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] private UnitSpawner unitSpawner;
    [SerializeField] private UnitDataViewer UDV;
    [SerializeField] private Mission mission;
    [SerializeField] private Hidden hidden;

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
        if (mission.ispanel == true|| hidden.ispanel == true) Iswindow = true;
        else if (mission.ispanel == false&& hidden.ispanel == false) Iswindow = false;
        if (Input.GetMouseButtonDown(0) && Iswindow == false)
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.CompareTag("UI")) return;

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
                        if (hit.transform.gameObject.GetComponent<UnitWeapon>().unitValue == UnitValue.Value5) return;

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
                            tile.IsCheck = false;
                            tile.isUnit1 = true;
                            tile = null;
                            IsCheckBlind = false;
                            hidden.Hidden1();
                            hidden.Hidden2();
                        }
                        else
                        {
                            tile.IsCheck = false;
                            tile = null;
                            IsCheckBlind = false;
                        }
                    }
                    else if (hit.transform.CompareTag("Unit"))
                    {
                        if(unitWeapon == null || hit.transform.gameObject != unitWeapon.gameObject)
                        {
                            tile.IsCheck = false;
                            tile = null;
                            IsCheckBlind = false;
                            return;
                        }
                        if (hit.transform.gameObject == unitWeapon.gameObject)
                        {
                            if (unitWeapon.unitValue == UnitValue.Value1)
                            {
                                unitSpawner.MergeUnit(unitWeapon,unitSpawner.unit1);
                                if (unitSpawner.merge) 
                                {
                                    unitSpawner.SpawnUnit2(tile.transform);
                                    unitWeapon.DestroyUnit();
                                    unitSpawner.unit1.Remove(unitWeapon);
                                    unitSpawner.merge = false;
                                    hidden.Hidden1();
                                    hidden.Hidden2();
                                    hidden.Hidden3();
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
                                    hidden.Hidden3();
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

                            tile.IsCheck = false;
                            tile = null;
                            unitWeapon = null;
                            IsCheckBlind = false;
                        }
                    }
                    else
                    {
                        tile.IsCheck = false;
                        tile = null;
                        IsCheckBlind = false;
                    }
                }
            }
        }
    }
}

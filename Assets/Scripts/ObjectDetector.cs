using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] private UnitSpawner unitSpawner;
    [SerializeField] private UnitDataViewer UDV;

    private new Camera camera;
    private Ray ray;
    private RaycastHit hit;

    private bool IsCheckBlind = false;
    private Tile tile;

    private void Awake()
    {
        camera = Camera.main;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                if (hit.transform.CompareTag("Tile"))
                {
                    if(!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit8 == true)
                    {

                    }
                    else if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit7 == true)
                    {
                        tile = hit.transform.gameObject.GetComponent<Tile>();
                        if (tile.IsBuildUnit == true) return;
                        tile.IsCheck = true;
                        IsCheckBlind = true;
                    }
                    else if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit6 == true)
                    {

                    }
                    else if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit5 == true)
                    {

                    }
                    else if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit4 == true)
                    {

                    }
                    else if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit3 == true)
                    {

                    }
                    else if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit2 == true)
                    {

                    }
                    else if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit1 == true)
                    {

                    }
                    else if (IsCheckBlind && hit.transform.gameObject == tile.gameObject)
                    {
                        unitSpawner.SpawnUnit(tile.transform);
                        tile.IsCheck = false;
                        tile.isUnit1 = true;
                        tile = null;
                        IsCheckBlind = false;
                    }
                    else
                    {
                        tile.IsCheck = false;
                        tile = null;
                        IsCheckBlind = false;
                    }
                    //if (!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().IsCheck == false)
                    //{
                    //    tile = hit.transform.gameObject.GetComponent<Tile>();

                    //    if (tile.IsBuildUnit == true) return;
                    //    tile.IsCheck = true;
                    //    IsCheckBlind = true;
                    //}
                    //else if(IsCheckBlind && hit.transform.gameObject == tile.gameObject)
                    //{
                    //    unitSpawner.SpawnUnit(tile.transform);
                    //    tile.IsCheck = false;
                    //    tile.isUnit1 = true;
                    //    tile = null;
                    //    IsCheckBlind = false;
                    //}
                    //else if(!IsCheckBlind && hit.transform.gameObject.GetComponent<Tile>().isUnit1 == true) 
                    //{
                    //    tile = hit.transform.gameObject.GetComponent<Tile>();
                    //    tile.IsCheck = true;
                    //    IsCheckBlind = true;
                    //}
                    //else
                    //{
                    //    tile.IsCheck = false;
                    //    tile = null;
                    //    IsCheckBlind = false;
                    //}
                }
                else if (hit.transform.CompareTag("Unit"))
                {
                    UDV.OnPane1(hit.transform);
                }
            }
        }
    }
}

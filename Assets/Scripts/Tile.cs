using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject CheckBlind;

    public bool IsBuildUnit { set; get; }
    public bool IsCheck { set; get; }

    private void Awake()
    {
        IsBuildUnit = false;
        IsCheck = false;
    }
    private void Update()
    {
        if (IsCheck) CheckBlind.SetActive(true);
        else CheckBlind.SetActive(false);
    }


}

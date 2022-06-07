using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject CheckBlind;
    
    public SpriteRenderer SR;

    public bool IsBuildUnit { set; get; }
    public bool IsCheck { set; get; }

    public bool isUnit1 { set; get; }
    public bool isUnit2 { set; get; }
    public bool isUnit3 { set; get; }
    public bool isUnit4 { set; get; }
    public bool isUnit5 { set; get; }
    public bool isUnit6 { set; get; }
    public bool isUnit7 { set; get; }
    public bool isUnit8 { set; get; }

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.color = new Color(0.84f, 0.84f, 0.84f);
        IsBuildUnit = false;
        IsCheck = false;
        isUnit1 = false;
        isUnit2 = false;
        isUnit3 = false;
        isUnit4 = false;
        isUnit5 = false;
        isUnit6 = false;
        isUnit7 = false;
        isUnit8 = false;
    }
    private void Update()
    {
        if (IsCheck) CheckBlind.SetActive(true);
        else CheckBlind.SetActive(false);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGold : MonoBehaviour
{
    [SerializeField] private int currentGold = 0;
    [SerializeField] private int currentGas = 0;

    public bool ant1;
    public bool ant2;
    public bool ant3;

    private void Start()
    {
        ant1 = false;
        ant2 = false;
        ant3 = false;
    }

    public int CurrentGold
    {
        //�ܺ� ��� ���� property
        set => currentGold = Mathf.Max(0, value);
        get => currentGold;
    }
    public int CurrentGas
    {
        //�ܺ� ��� ���� property
        set => currentGas = Mathf.Max(0, value);
        get => currentGas;
    }
}

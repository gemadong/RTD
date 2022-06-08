using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGold : MonoBehaviour
{
    [SerializeField] private int currentGold = 0;

    public int CurrentGold
    {
        //외부 사용 가능 property
        set => currentGold = Mathf.Max(0, value);
        get => currentGold;
    }
}

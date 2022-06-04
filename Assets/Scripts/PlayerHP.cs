using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float maxHP = 20f;
    private float currentHP;

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake()
    {
        currentHP = maxHP;
    }
    public void DMG(float dmg)
    {
        currentHP -= dmg;
        if (currentHP <= 0)
        {
            Debug.Log("게임 오버!");
        }
    }




}

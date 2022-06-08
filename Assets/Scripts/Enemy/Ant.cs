using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] private int price;

    protected override void Die()
    {
        if (currentHP <= 0)
        {
            PlayerGold PG = FindObjectOfType<PlayerGold>();
            PG.CurrentGold += price;
            isDie = true;
            OnDie(DestroyType.Kill);
        }
    }

}

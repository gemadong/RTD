using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AntValue
{
    Ant1,
    Ant2,
    Ant3,
}

public class Ant : Enemy
{
    [SerializeField] private int price;
    public AntValue antValue;
    

    protected override void Die()
    {
        if (currentHP <= 0)
        {
            PlayerGold PG = FindObjectOfType<PlayerGold>();
            if (antValue == AntValue.Ant1 && PG.ant1 == false) 
            { 
                PG.CurrentGold += price;
                PG.ant1 = true;
            }
            if(antValue == AntValue.Ant2 && PG.ant2==false)
            {
                PG.CurrentGold += price;
                PG.ant2 = true;
            }
            if (antValue == AntValue.Ant3 && PG.ant3==false)
            {
                PG.CurrentGold += price;
                PG.ant3 = true;
            }
            PG.CurrentGold += price;
            
            isDie = true;
            OnDie(DestroyType.Kill,enemyType);
        }
    }

}

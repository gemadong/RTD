using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit4 : UnitWeapon
{
    protected override void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.GetComponent<LongBullet>().Setup(Target, Damage + upGrade);
    }
}

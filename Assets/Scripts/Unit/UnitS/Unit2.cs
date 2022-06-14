using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit2 : UnitWeapon
{
    protected override void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.GetComponent<PenetrateBullet>().Setup(Target, power + upGrade);
    }
}

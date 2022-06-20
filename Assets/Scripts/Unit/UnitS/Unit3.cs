using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit3 : UnitWeapon
{
    protected override void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.GetComponent<CushionBullet>().Setup(Target, (power + upGrade)/3);
    }
}

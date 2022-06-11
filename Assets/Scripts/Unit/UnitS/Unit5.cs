using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit5 : UnitWeapon
{
    protected override IEnumerator Attack()
    {
        while (true)
        {
            if (Target == null)
            {
                ChangeState(WeaponState.Search);
                break;
            }

            float distance = Vector3.Distance(Target.position, transform.position);
            if (distance > attackRange)
            {
                Target = null;
                ChangeState(WeaponState.Search);
                break;
            }
            yield return new WaitForSeconds(0.1f);
            SpawnBullet();
            yield return new WaitForSeconds(attackRate);
        }
    }
    protected override void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.transform.rotation = transform.rotation;
        clone.GetComponent<Splash>().Setup(Target, power);
    }
}

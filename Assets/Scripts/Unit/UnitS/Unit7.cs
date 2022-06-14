using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit7 : UnitWeapon
{
    [SerializeField] private GameObject Claw;

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
        if (Target != null)
        {
            GameObject clone1 = Instantiate(Claw, spawnPoint.position, Quaternion.identity);
            GameObject clone2 = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
            clone1.transform.rotation = transform.rotation;
            clone2.GetComponent<MagicClaw>().Setup(Target, power + upGrade, clone1);
        }
        
    }

}

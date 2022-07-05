using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit7 : UnitWeapon
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
            animator.SetTrigger("Atk");
            yield return new WaitForSeconds(0.2f);
            SpawnBullet();
            yield return new WaitForSeconds(attackRate);
        }
    }
    protected override void SpawnBullet()
    {
        if (Target != null)
        {
            GameObject clone2 = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
            clone2.GetComponent<MagicClaw>().Setup(Target, power + upGrade);
        }
        
    }

}

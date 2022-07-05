using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit5 : UnitWeapon
{
    [SerializeField] private Transform rot;
    protected override void Update()
    {
        if (Target != null) 
        { 
            RotateToTarget();
            RotRotateToTarget(rot);
        } 
    }
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
            animator.SetTrigger("Atk");
            SpawnBullet();
            yield return new WaitForSeconds(attackRate);
        }
    }
    protected override void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.transform.rotation = rot.rotation;
        clone.GetComponent<Splash>().Setup(Target, power + upGrade);
    }
    protected override void RotateToTarget()
    {
        float dx = Target.position.x - transform.position.x;
        float dy = Target.position.y - transform.position.y;

        float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        if (degree < 90 && degree >= -90)
        {
            animator.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else 
        {
            animator.transform.localScale = new Vector3(1f, 1f, 1f);
        } 
    }


    void RotRotateToTarget(Transform bullet)
    {
        float dx = Target.position.x - transform.position.x;
        float dy = Target.position.y - transform.position.y;

        float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        bullet.rotation = Quaternion.Euler(0, 0, degree+180f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponState
{
    Search,
    Attack
}

public class UnitWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float attackRate = 0.5f;
    [SerializeField] private float attackRange = 2.0f;
    [SerializeField] private float power = 60f;

    private WeaponState weaponState = WeaponState.Search;
    private Transform Target = null;
    private EnemySpawner ES;

    public void Setup(EnemySpawner ES)
    {
        this.ES = ES;
        ChangeState(WeaponState.Search);
    }

    public void ChangeState(WeaponState newState)
    {
        StopCoroutine(weaponState.ToString());
        weaponState = newState;
        StartCoroutine(weaponState.ToString());
    }

    private void Update()
    {
        if (Target != null) RotateToTarget();
    }
    void RotateToTarget()
    {
        float dx = Target.position.x - transform.position.x;
        float dy = Target.position.y - transform.position.y;

        float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, degree);
    }

    private IEnumerator Search()
    {
        while (true)
        {
            float closestDistSqr = Mathf.Infinity;
            for(int i = 0; i < ES.EnemyList.Count; ++i)
            {
                float distance = Vector3.Distance(ES.EnemyList[i].transform.position, transform.position);

                if(distance <= attackRange && distance <= closestDistSqr)
                {
                    closestDistSqr = distance;
                    Target = ES.EnemyList[i].transform;
                }
            }
            if (Target != null) ChangeState(WeaponState.Attack);

            yield return null;
        }
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            if(Target == null)
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
            yield return new WaitForSeconds(attackRate);
            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.GetComponent<Bullet>().Setup(Target, power);
    }

}

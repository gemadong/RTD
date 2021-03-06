using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponState
{
    Search,
    Attack
}

public enum UnitValue
{
    Value1,
    Value2,
    Value3,
    Value4,
    Value5
}

public enum UnitType
{
    Type1,
    Type2,
    Type3,
    Type4,
    Type5,
    Type6,
    Type7,
    Type8
}

public class UnitWeapon : MonoBehaviour
{
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected GameObject check;
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected Animator animator;
    [SerializeField] protected float attackRate = 0.5f;
    [SerializeField] protected float attackRange = 2.0f;
    [SerializeField] protected float power = 60f;
    [SerializeField] protected Transform Target = null;

    public UnitType unitType;
    public UnitValue unitValue;
    private WeaponState weaponState = WeaponState.Search;

    private EnemySpawner ES;
    public Tile currentTile = null;

    public float upGrade=0;
    public float reinforce = 0;
    public float Damage => power + ((power / 100) *  reinforce);
    public float Rate => attackRate;
    public float Range => attackRange;

    bool isCheck = false;

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

    protected virtual void Update()
    {
        if (Target != null) RotateToTarget();
    }
    protected virtual void RotateToTarget()
    {
        float dx = Target.position.x - transform.position.x;
        float dy = Target.position.y - transform.position.y;

        float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        if (degree < 90 && degree >= -90)
        {
            animator.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else animator.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private IEnumerator Search()
    {
        while (true)
        {
            float closestDistSqr = Mathf.Infinity;
            animator.SetBool("Idle", true);
            for (int i = 0; i < ES.EnemyList.Count; ++i)
            {
                float distance = Vector3.Distance(ES.EnemyList[i].transform.position, transform.position);

                if(distance <= attackRange && distance <= closestDistSqr)
                {
                    closestDistSqr = distance;
                    Target = ES.EnemyList[i].transform;
                }
            }
            if (Target != null && Target.GetComponent<Enemy>().die == false) ChangeState(WeaponState.Attack);

            yield return null;
        }
    }

   protected virtual IEnumerator Attack()
    {
        while (true)
        {
            if(Target == null || Target.GetComponent<Enemy>().die == true)
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
            SpawnBullet();
            yield return new WaitForSeconds(attackRate);
        }
    }

    protected virtual void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.GetComponent<Bullet>().Setup(Target, Damage+upGrade);
    }

    public void DestroyUnit()
    {
        Destroy(gameObject);
    }

    public void PowerUP(float f)
    {
        upGrade += f;
    }

    public void Check()
    {
        if (isCheck)
        {
            check.SetActive(false);
            isCheck = false;
        }
        else
        {
            check.SetActive(true);
            isCheck = true;
        }
    }

}

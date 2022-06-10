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
    [SerializeField] private SpriteRenderer SR;
    [SerializeField] protected Transform spawnPoint;
    [SerializeField] protected float attackRate = 0.5f;
    [SerializeField] protected float attackRange = 2.0f;
    [SerializeField] protected float power = 60f;
    [SerializeField] private int level = 0;
    [SerializeField] protected Transform Target = null;

    public UnitType unitType;
    public UnitValue unitValue;
    private WeaponState weaponState = WeaponState.Search;

    private EnemySpawner ES;
    public Tile currentTile = null;

    public float Damage => power;
    public float Rate => attackRate;
    public float Range => attackRange;
    public int Level => level + 1;
    public Sprite imageUnit => SR.sprite;
    public Color color => SR.color;


    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }

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

   protected virtual IEnumerator Attack()
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
            SpawnBullet();
            yield return new WaitForSeconds(attackRate);
        }
    }

    protected virtual void SpawnBullet()
    {
        GameObject clone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        clone.GetComponent<Bullet>().Setup(Target, power);
    }

    public void DestroyUnit()
    {
        Destroy(gameObject);
    }

}

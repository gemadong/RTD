using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CushionBullet : MonoBehaviour
{
    [SerializeField] private EnemySpawner ES;
    private Transform target;

    private float power = 10f;
    private float moveSpeed = 5f;

    private int count= 0;

    private void Awake()
    {
        ES = FindObjectOfType<EnemySpawner>();
    }
    public void Setup(Transform target, float power)
    {
        this.target = target;
        this.power = power;
    }
    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        if (other.transform != target) return;

        other.GetComponent<Enemy>().DMG(power);
        count += 1;
        
        Search();

        if (target==null||count >= 3)
        {
            Destroy(gameObject);
        }
    }
    private void Search()
    {
        float closestDistSqr = Mathf.Infinity;
        for (int i = 0; i < ES.EnemyList.Count; ++i)
        {
            float distance = Vector3.Distance(ES.EnemyList[i].transform.position, transform.position);
            if (distance >= 1f && distance <= 2f && distance <= closestDistSqr)
            {
                closestDistSqr = Vector3.Distance(ES.EnemyList[i].transform.position, transform.position);
                target = ES.EnemyList[i].transform;
            }
        }
        if (closestDistSqr == Mathf.Infinity) Destroy(gameObject);
    }
}

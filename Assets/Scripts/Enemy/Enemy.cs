using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DestroyType
{
    Kill,
    Arrice
}

public class Enemy : MonoBehaviour
{
    private int wayPointCount;
    private Transform[] wayPoints;
    private int currentIndex = 0;
    private Movement movement;
    private EnemySpawner ES;

    public float maxHP;
    protected float currentHP;
    protected bool isDie = false;

    public float MaxHP => maxHP;
    public float CurrentHP => currentHP;

    private void Awake()
    {
        currentHP = maxHP;
    }

    public void Setup(EnemySpawner ES, Transform[] waypoints)
    {
        movement = GetComponent<Movement>();
        this.ES = ES;

        wayPointCount = waypoints.Length;
        this.wayPoints = new Transform[wayPointCount];
        this.wayPoints = waypoints;

        transform.position = waypoints[currentIndex].position;

        StartCoroutine("OnMove");
    }


    IEnumerator OnMove()
    {
        NextMoveTo();

        while (true)
        {
            //transform.Rotate(Vector3.forward * 10);

            if (Vector3.Distance(transform.position, wayPoints[currentIndex].position) < 0.05f * movement.MoveSpeed)
            {
                NextMoveTo();
            }
            yield return null;
        }
    }

    private void NextMoveTo()
    {
        if(currentIndex < wayPointCount - 1)
        {
            transform.position = wayPoints[currentIndex].position;
            currentIndex++;
            Vector3 direction = (wayPoints[currentIndex].position - transform.position).normalized;
            movement.MoveTo(direction);
        }
        else
        {
            OnDie(DestroyType.Arrice);
        }
    }
     
    public void DMG(float dmg)
    {
        if (isDie) return;

        currentHP -= dmg;


        Die();
    }

    public void OnDie(DestroyType type)
    {
        ES.DestroyEnemy(type,this);
    }
    protected virtual void Die()
    {
        if (currentHP <= 0)
        {
            isDie = true;
            OnDie(DestroyType.Kill);
        }
    }

}

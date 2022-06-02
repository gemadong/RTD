using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int wayPointCount;
    private Transform[] wayPoints;
    private int currentIndex = 0;
    private Movement movement;
    private EnemySpawner ES;

    public float Hp = 100f;
    
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

            if (Vector3.Distance(transform.position, wayPoints[currentIndex].position) < 0.02f * movement.MoveSpeed)
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
            OnDie();
        }
    }

    public void DMG(float dmg)
    {
        if (Hp > 0) Hp -= dmg; 
        else OnDie();
        Debug.Log(Hp);
    }

    public void OnDie()
    {
        ES.DestroyEnemy(this);
    }

}

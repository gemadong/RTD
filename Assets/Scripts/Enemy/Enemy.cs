using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DestroyType
{
    Kill,
    Arrice
}
public enum EnemyType
{
    Enemy,
    Ant,
    Boss
}


public class Enemy : MonoBehaviour
{
    protected int wayPointCount;
    protected Transform[] wayPoints;
    protected int currentIndex = 0;
    protected Movement movement;
    private EnemySpawner ES;
    
    public EnemyType enemyType;

    public float maxHP;
    public float currentHP;
    protected bool isDie = false;

    public Animator animator;

    public bool die = false;
    private void Start()
    {
        transform.localScale = new Vector3(-1f, 1f, 1f);
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
            if (Vector3.Distance(transform.position, wayPoints[currentIndex].position) < 0.1f * movement.moveSpeed)
            {
                NextMoveTo();
            }
            yield return null;
        }
    }

    protected virtual void NextMoveTo()
    {
        if(currentIndex < wayPointCount - 1)
        {
            if(currentIndex ==1|| currentIndex ==2|| currentIndex == 5 || currentIndex == 6 || currentIndex == 9 || currentIndex == 10)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            else transform.localScale = new Vector3(1f, 1f, 1f);
            transform.position = wayPoints[currentIndex].position;
            currentIndex++;
            Vector3 direction = (wayPoints[currentIndex].position - transform.position).normalized;
            movement.MoveTo(direction);
            
        }
        else
        {
            OnDie(DestroyType.Arrice,enemyType);
        }
    }
     
    public void DMG(float dmg)
    {
        if (isDie) return;

        currentHP -= dmg;


        Die();
    }

    public void OnDie(DestroyType type,EnemyType Etype)
    {
        ES.DestroyEnemy(type,this,Etype);
    }

    protected virtual void Die()
    {
        if (currentHP <= 0)
        {
            WaveManager WM = FindObjectOfType<WaveManager>();
            if(WM.wave ==10|| WM.wave == 20|| WM.wave == 30)
            {
                Draw draw = FindObjectOfType<Draw>();
                draw.draw += 1;
            }
            isDie = true;
            die = true;
            OnDie(DestroyType.Kill, enemyType);
        }
    }

    public void DieAnimation()
    {
        StartCoroutine("DieAni");
    }

    IEnumerator DieAni()
    {
        die = true;
        movement.moveSpeed = 0f;
        animator.SetTrigger("Die");
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}

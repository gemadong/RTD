using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTutorial1 : Enemy
{
    protected override void NextMoveTo()
    {
        if (currentIndex < wayPointCount - 1)
        {
            if (currentIndex == 4)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            transform.position = wayPoints[currentIndex].position;
            currentIndex++;
            Vector3 direction = (wayPoints[currentIndex].position - transform.position).normalized;
            movement.MoveTo(direction);

        }
        else
        {
            OnDie(DestroyType.Arrice, enemyType);
        }
    }
}

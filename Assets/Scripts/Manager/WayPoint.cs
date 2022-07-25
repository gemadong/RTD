using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    private Movement movement;
    private int wayPointCount;
    private Transform[] wayPoints;
    private int currentIndex = 0;

    public void Setup(Transform[] waypoints)
    {
        movement = GetComponent<Movement>();

        wayPointCount = waypoints.Length;
        this.wayPoints = new Transform[wayPointCount];
        this.wayPoints = waypoints;
        movement.moveSpeed = 10f;
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

    private void NextMoveTo()
    {
        if (currentIndex < wayPointCount - 1)
        {
            if (currentIndex == 1 || currentIndex == 2 || currentIndex == 5 || currentIndex == 6 || currentIndex == 9 || currentIndex == 10)
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
            FindObjectOfType<TutorialObjectDetector>().stop = false;
            FindObjectOfType<TutorialObjectDetector>().TutorialPanel();
            Destroy(gameObject);
        }
    }
}

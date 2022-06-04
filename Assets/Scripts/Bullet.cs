using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Movement movement;
    private Transform target;

    private float power = 10f;

    public void Setup(Transform target, float power)
    {
        movement = GetComponent<Movement>();
        this.target = target;
        this.power = power;
    }
    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            movement.MoveTo(direction);
        }
        else Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        if (other.transform != target) return;

        other.GetComponent<Enemy>().DMG(power);
        Destroy(gameObject);
    }

}
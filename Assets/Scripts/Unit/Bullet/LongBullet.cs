using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongBullet : MonoBehaviour
{
    private Transform target;

    private float power = 10f;

    public void Setup(Transform target, float power)
    {
        this.target = target;
        this.power = power;
    }
    private void Update()
    {

        if (target != null)
        {
            transform.Rotate(Vector3.forward * 8);
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * 5f * Time.deltaTime;
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

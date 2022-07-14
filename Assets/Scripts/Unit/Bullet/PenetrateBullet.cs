using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetrateBullet : MonoBehaviour
{
    [SerializeField] private float maxTime;
 
    Vector3 direction;
    private Transform target;

    private float moveSpeed = 7f;
    private float power;
    private float currentTime = 0;

    bool Pos = false;

    public void Setup(Transform target, float power)
    {
        direction = (target.position - transform.position).normalized;
        this.target = target;
        this.power = power;
        if (!Pos) RotateToTarget();
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        transform.position += (direction+direction) * moveSpeed * Time.deltaTime;
        if (currentTime >= maxTime) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground")) Destroy(gameObject);

        if (other.CompareTag("Enemy"))
        {
            Pos = true;
            other.GetComponent<Enemy>().DMG(power);
        }
    }
    void RotateToTarget()
    {
        float dx = target.position.x - transform.position.x;
        float dy = target.position.y - transform.position.y;

        float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, degree);
    }
}

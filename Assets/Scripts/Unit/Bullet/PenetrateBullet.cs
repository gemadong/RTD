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

    bool isDmg = true;
    bool Pos = false;

    public void Setup(Transform target, float power)
    {
        direction = (target.position - transform.position).normalized;
        this.target = target;
        this.power = power;
        
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        transform.Rotate(Vector3.forward * 5);

        transform.position += (direction+direction) * moveSpeed * Time.deltaTime;
        if (currentTime >= maxTime) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground")) Destroy(gameObject);

        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().DMG(power);
            isDmg = true;
        }
    }
}

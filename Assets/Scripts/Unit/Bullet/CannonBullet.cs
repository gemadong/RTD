using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBullet : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    private Transform target;

    private float power;

    public void Setup(Transform target, float power)
    {
        this.target = target;
        this.power = power;
        explosion.GetComponent<Explosion>().power = power;
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * 5f * Time.deltaTime;

            if (Vector3.Distance(transform.position, direction) <= 0.2f) explosion.SetActive(true);
        }
        else Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        explosion.SetActive(true);
        
    }




}

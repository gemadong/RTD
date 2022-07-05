using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBullet : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    public Transform target;

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
            RotateToTarget();

            if (Vector3.Distance(transform.position, direction) <= 0.2f) 
            { 
                explosion.SetActive(true);
                transform.position = this.transform.position;
            } 
            else transform.position += direction * 5f * Time.deltaTime;
        }
        else Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Color recolor = this.GetComponent<SpriteRenderer>().color;
        recolor.a = 0;
        this.GetComponent<SpriteRenderer>().color = recolor;
        explosion.SetActive(true);

        
    }

    void RotateToTarget()
    {
        float dx = target.position.x - transform.position.x;
        float dy = target.position.y - transform.position.y;

        float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, degree);
    }


}

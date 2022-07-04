using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    private Transform target;
    private SpriteRenderer SR;
    
    private float power;
    private float i=1;

    Color color;
    Vector3 Pos;

    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        color = SR.color;
        Pos = transform.position;
        Pos.z = 0;
        transform.position = Pos;
    }

    public void Setup(Transform target, float power)
    {
        this.target = target;
        this.power = power;
    }

    private void Update()
    {
        i -= Time.deltaTime*1.5f;
        color.a = i;
        SR.color = color;
        if (target == null) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        StartCoroutine(Impact(other));
    }

    private IEnumerator Impact(Collider2D other)
    {
        other.GetComponent<Enemy>().DMG(power);
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
    void RotateToTarget()
    {
        float dx = target.position.x - transform.position.x;
        float dy = target.position.y - transform.position.y;

        float degree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, degree);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicClaw : MonoBehaviour
{
    private Transform target;
    private SpriteRenderer SR;
    private GameObject Claw;

    private float power;


    public void Setup(Transform target, float power)
    {
        this.target = target;
        this.power = power;

    }

    private void Update()
    {
        if (target != null) transform.position = target.position;
        else Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        if (other.transform != target) return;
        StartCoroutine(Impact(other));
    }

    private IEnumerator Impact(Collider2D other)
    {
        other.GetComponent<Enemy>().DMG(power);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}

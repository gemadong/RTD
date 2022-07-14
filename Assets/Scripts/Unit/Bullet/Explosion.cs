using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    
    public float power;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        StartCoroutine(Impact(other));
    }

    private IEnumerator Impact(Collider2D other)
    {
        other.GetComponent<Enemy>().DMG(power);
        CircleCollider2D Col = GetComponent<CircleCollider2D>();
        Col.enabled = false;
        yield return new WaitForSeconds(1f);
        Destroy(bullet);
    }

}

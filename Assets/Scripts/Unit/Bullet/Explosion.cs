using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    private SpriteRenderer SR;
    private Color color;
    
    public float power;
    private float i = 0;

    private bool max = false;

    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        color = SR.color;
    }
    private void Update()
    {
        if (!max)
        {
            i += Time.deltaTime *2f;
            
            if (i >= 1) max = true;
        }
        if(max)
        {
            i -= Time.deltaTime * 0.8f;
            if (i <= 1) Destroy(bullet);
        }
        color.a = i;
        SR.color = color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy")) return;
        StartCoroutine(Impact(other));
    }

    private IEnumerator Impact(Collider2D other)
    {
        other.GetComponent<Enemy>().DMG(power);
        yield return new WaitForSeconds(5f);
        Destroy(bullet);
    }
}

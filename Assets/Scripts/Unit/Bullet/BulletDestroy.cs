using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("DestrotyBullet");
    }

    IEnumerator DestrotyBullet()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}

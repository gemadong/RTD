using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitEffect : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyEffect());
    }


    IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{
    public void OnAttackRange(Vector3 pos, float range)
    {
        gameObject.SetActive(true);

        float diameter = range * 2f;
        transform.localScale = Vector3.one * diameter;
        transform.position = pos;
    }
    public void OffAttackRange()
    {
        gameObject.SetActive(false);
    }
}

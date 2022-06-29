using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPbarPos : MonoBehaviour
{
    [SerializeField] private Vector3 distance = Vector3.up * 20f;

    private Transform targetTransform;
    private RectTransform rect;

    public void Setup(Transform target)
    {
        targetTransform = target;
        rect = GetComponent<RectTransform>();
    }

    private void LateUpdate()
    {
        if(targetTransform == null|| targetTransform.gameObject.GetComponent<Enemy>().currentHP <= 0)
        {
            Destroy(gameObject);
            return;
        }
        rect.position = targetTransform.position + distance;

    }


}

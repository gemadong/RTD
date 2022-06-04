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
        if(targetTransform == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 screenPos = Camera.main.WorldToScreenPoint(targetTransform.position);
        rect.position = screenPos + distance;

    }




}

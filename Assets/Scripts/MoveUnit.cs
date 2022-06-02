using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnit : MonoBehaviour
{
    public bool isFollow = false;

    void Update()
    {
        if (isFollow)
        {
        }
    }

    private void Follow(Transform transform)
    {
        this.transform.position += transform.position;
    }
}

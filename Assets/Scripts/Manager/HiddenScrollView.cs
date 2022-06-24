using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiddenScrollView : MonoBehaviour
{
    public Scrollbar scrollbar;

    void Start()
    {
        scrollbar.value = 1f;
    }
}

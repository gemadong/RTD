using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DrawScrollWiew : MonoBehaviour
{
    public Scrollbar scrollbar;

    const int Size = 4;
    float[] pos = new float[Size];
    float distance, targetPos;

    void Start()
    {
        distance = 1f / (Size - 1); // 0.5
        scrollbar.value = 0f;
        for (int i = 0; i < Size; i++) pos[i] = distance * i;
    }
    void Update()
    {
        scrollbar.value = Mathf.Lerp(scrollbar.value, targetPos, 0.1f);
    }

    public void ScroolC(int i)
    {
        targetPos = 1 - pos[i];
    }
}

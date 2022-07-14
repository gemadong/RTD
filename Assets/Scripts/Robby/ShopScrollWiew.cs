using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopScrollWiew : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public Scrollbar scrollbar;

    const int Size = 3;
    float[] pos = new float[Size];
    float distance, targetPos;
    bool isDrag = true;

    void Start()
    {
        distance = 1f / (Size - 1); // 0.5
        scrollbar.value = 1f;
        for (int i = 0; i < Size; i++) pos[i] = distance * i;
    }
    public void OnDrag(PointerEventData eventData)
    {
        isDrag = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDrag = false;
        for (int i = 0; i < Size; i++)
        {
            if (scrollbar.value < pos[i] + distance * 0.5f && scrollbar.value > pos[i] - distance * 0.5f)
            {
                targetPos = pos[i];
            }
        }
    }

    void Update()
    {
        if (!isDrag) scrollbar.value = Mathf.Lerp(scrollbar.value, targetPos, 0.1f);
    }

    public void ScroolC(int i)
    {
        isDrag = true;
        targetPos = 1 - pos[i];
        isDrag = false;
    }
}

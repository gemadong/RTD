using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraShake : MonoBehaviour
{
    public Image BloodObj;
    
    public Camera mainC;
    Vector3 cameraPos;
    Vector3 Pos;

    float a = 125f;
    Color recolor;

    bool isBlood = false;


    [SerializeField] [Range(0.01f, 0.1f)] float shakeRange = 0.05f;
    [SerializeField] [Range(0.1f, 1f)] float duration = 0.5f;
    private void Start()
    {
        Pos = mainC.transform.position;
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) Shake();
    }

    public void Shake()
    {
        cameraPos = mainC.transform.position;
        InvokeRepeating("StartShake", 0f, 0.005f);
        Invoke("StopShake", duration);
    }

    void StartShake()
    {
        BloodObj.gameObject.SetActive(true);
        float PosX = Random.value * shakeRange * 2 - shakeRange;
        float PosY = Random.value * shakeRange * 2 - shakeRange;
        cameraPos.x += PosX;
        cameraPos.y += PosY;
        mainC.transform.position = cameraPos;

    }

    void StopShake()
    {
        BloodObj.gameObject.SetActive(false);
        CancelInvoke("StartShake");
        mainC.transform.position = Pos;
    }


}

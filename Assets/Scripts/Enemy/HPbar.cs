using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    private Enemy enemy;
    private Slider hp;

    public void Setup(Enemy enemy)
    {
        this.enemy = enemy;
        hp = GetComponent<Slider>();
    }

    private void Update()
    {
        hp.value = enemy.currentHP / enemy.maxHP;
    }






}

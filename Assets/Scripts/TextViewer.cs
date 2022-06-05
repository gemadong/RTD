using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextViewer : MonoBehaviour
{
    [SerializeField] private Text playerHPText;
    [SerializeField] private Text playerGoldText;
    [SerializeField] private Text waveText;
    [SerializeField] private Text enemyCountText;
    [SerializeField] private PlayerHP playerHP;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private WaveManager wave;
    [SerializeField] private EnemySpawner ES;



    private void Update()
    {
        playerHPText.text = "HP : " + playerHP.CurrentHP + "/" + playerHP.MaxHP;
        playerGoldText.text = "Gold : " + playerGold.CurrentGold.ToString();
        waveText.text = "Wave : " + wave.CurrentWave + "/" + wave.Maxwave;
        enemyCountText.text = "Enemy : " + ES.CurrentEnemyCount + "/" + ES.MaxEnemyCount;
    }
}

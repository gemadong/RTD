using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextViewer : MonoBehaviour
{
    [SerializeField] private Text playerHPText;
    [SerializeField] private Text playerGoldText;
    [SerializeField] private Text playerGasText;
    [SerializeField] private Text waveText;
    [SerializeField] private Text enemyCountText;
    [SerializeField] private PlayerHP playerHP;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private WaveManager wave;
    [SerializeField] private EnemySpawner ES;



    private void Update()
    {
        playerHPText.text = "Life       " + playerHP.CurrentHP + "/" + playerHP.MaxHP;
        playerGoldText.text = "Gold           " + playerGold.CurrentGold.ToString();
        playerGasText.text = "Gas             " + playerGold.CurrentGas.ToString();
        waveText.text = "Round  " + wave.CurrentWave + "/" + wave.Maxwave;
        enemyCountText.text = "Enemy       " + ES.CurrentEnemyCount + "/" + ES.MaxEnemyCount;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextViewer : MonoBehaviour
{
    [SerializeField] private PlayerHP playerHP;
    [SerializeField] private PlayerGold playerGold;
    [SerializeField] private WaveManager wave;
    [SerializeField] private EnemySpawner ES;

    [SerializeField] private Text playerHPText;
    [SerializeField] private Text playerGoldText;
    [SerializeField] private Text playerGasText;
    [SerializeField] private Text waveText;
    [SerializeField] private Text killText;
    [SerializeField] private Text timeText;
    


    private void Update()
    {
        playerHPText.text = "Life           " + playerHP.CurrentHP; // + "/" + playerHP.MaxHP;
        playerGoldText.text = "Gold           " + playerGold.CurrentGold.ToString();
        playerGasText.text = "Gas : " + playerGold.CurrentGas.ToString();
        waveText.text = "Round       " + wave.CurrentWave; // + "/" + wave.Maxwave;
        killText.text = "Kill              " + ES.killCount;
        timeText.text = "Time           " + (wave.maxTime - (wave.currentTime - (wave.currentTime % 1)));
    }
}

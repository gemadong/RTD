using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private Wave[] waves;
    [SerializeField] private EnemySpawner ES;
    [SerializeField] private GameManager GM;
    [SerializeField] private PlayerGold PG;
    private int currentWaveIndex = -1;
    public int wave = 1;

    public float maxTime = 20f;
    public float currentTime = 0f;

    public int CurrentWave => currentWaveIndex + 1;
    public int Maxwave => waves.Length;

    public bool waitingTime = false;

    private void Update()
    {
        if (ES.EnemyList.Count == 0||waitingTime)
        {
            if (wave == Maxwave+1) GM.GameClear();

            if (wave == CurrentWave)
            {
                PG.CurrentGold += 200;
                wave++;
            }
            waitingTime = true;
            currentTime += Time.deltaTime;

            if (currentTime > maxTime)
            {
                waitingTime = false;
                StartWave();
                currentTime = 0;
            }
        }
    }

    public void StartWave()
    {
        if(ES.EnemyList.Count == 0 && currentWaveIndex < waves.Length - 1)
        {
            currentWaveIndex++;
            ES.StartWave(waves[currentWaveIndex]);
        }
    }
}

[System.Serializable]
public struct Wave
{
    public float spawnTime;
    public int maxEnemyCount;
    public GameObject enemyPrefab;
}

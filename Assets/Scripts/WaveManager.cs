using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private Wave[] waves;
    [SerializeField] private EnemySpawner ES;
    [SerializeField] private PlayerGold PG;
    private int currentWaveIndex = -1;

    private float maxTime = 20f;
    public float currentTime = 0f;

    private void Update()
    {
        if (ES.EnemyList.Count == 0)
        {
            currentTime += Time.deltaTime;
            
            if (currentTime > maxTime)
            {
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

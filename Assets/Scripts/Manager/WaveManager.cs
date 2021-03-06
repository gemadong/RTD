using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private Wave[] waves;
    [SerializeField] private EnemySpawner ES;
    [SerializeField] private TimeManager TM;
    [SerializeField] private TutorialObjectDetector TOD;
    [SerializeField] private GameManager GM;
    [SerializeField] private PlayerGold PG;
    [SerializeField] private Text stageText;

    private int currentWaveIndex = -1;
    public int wave = 1;

    public float maxTime = 20f;
    public float currentTime = 0f;
    float f = 1f;

    public int CurrentWave => currentWaveIndex + 1;
    public int Maxwave => waves.Length;

    public bool waitingTime = false;
    public bool TextTime = false;
    public bool isStop = false;

    private void Update()
    {
        if (ES.EnemyList.Count == 0 || waitingTime)
        {
            if (wave == Maxwave + 1) 
            { 
                GM.GameClear();
                wave ++;
            } 

            if (wave == CurrentWave)
            {
                if (wave == 1 && TOD != null) 
                { 
                    TOD.TutorialPanel();
                    isStop = true;
                }
                if (wave == 2 && TOD != null)
                {
                    TOD.TutorialPanel();
                    isStop = true;
                }
                PG.CurrentGold += 200;
                if(wave % 10 == 0) PG.CurrentGold += 200;
                wave++;
            }
            waitingTime = true;
            if(!isStop) currentTime += Time.deltaTime;

            if (currentTime > maxTime)
            {
                if (wave == 1 && TOD != null) TOD.TutorialPanel();
                StartWave();
                TextTime = true;
                currentTime = 0;
                waitingTime = false;
            }
        }
        if (TextTime)
        {
            stageText.gameObject.SetActive(true);
            if(TM.isSpeed==1) f -= Time.deltaTime *0.5f;
            if(TM.isSpeed==2) f -= (Time.deltaTime *0.5f)*0.5f;
            if(TM.isSpeed==3) f -= (Time.deltaTime *0.5f)*0.3333f;
            Color recolor = stageText.color;
            recolor.a = f;
            stageText.color = recolor;
            stageText.text = CurrentWave.ToString() + " STAGE";
            if (f <= 0)
            {
                stageText.gameObject.SetActive(false);
                f = 1;
                TextTime = false;
            }
        }
    }

    public void StartWave()
    {
        if(ES.EnemyList.Count == 0 && currentWaveIndex < waves.Length - 1 || waitingTime)
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

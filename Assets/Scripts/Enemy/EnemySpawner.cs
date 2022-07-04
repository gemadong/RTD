using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] AntPrifab;
    [SerializeField] private GameObject hpSlinder;
    [SerializeField] private GameObject AnthpSlinder;
    [SerializeField] private GameObject WayPoint;
    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private Transform canvas;
    [SerializeField] private PlayerHP playerHP;
    [SerializeField] private Mission mission;
    [SerializeField] private WaveManager WM;


    private Wave currentWave;
    private List<Enemy> enemyList;
    public List<Enemy> EnemyList => enemyList;

    private int currentEnemyCount;

    public int CurrentEnemyCount => currentEnemyCount;
    public int MaxEnemyCount => currentWave.maxEnemyCount;

    public int killCount = 0;


    public float[] enemyHP;

    private void Awake()
    {
        enemyList = new List<Enemy>();
        StartCoroutine("SpawnEnemy");
        killCount = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnWay();
        }
    }
    public void StartWave(Wave wave)
    {
        currentWave = wave;
        currentEnemyCount = currentWave.maxEnemyCount;
        StartCoroutine("SpawnEnemy");
    }
    private void SpawnWay()
    {
        GameObject clone = Instantiate(WayPoint);
        WayPoint way = clone.GetComponent<WayPoint>();
        
        way.Setup(wayPoints);
    }
    private IEnumerator SpawnEnemy()
    {
        //생성된 에너미 숫자
        int spawnEnemyCount = 0;

        while (spawnEnemyCount < currentWave.maxEnemyCount)
        {
            GameObject clone = Instantiate(currentWave.enemyPrefab);
            Enemy enemy = clone.GetComponent<Enemy>();
            enemy.maxHP = enemyHP[WM.wave-1];
            enemy.currentHP = enemy.maxHP;
            enemy.Setup(this,wayPoints);
            enemyList.Add(enemy);

            if (WM.wave % 10 == 0) hpSlinder.GetComponent<HPbarPos>().distance = new Vector3(0.1f, 1f, 0f);
            else hpSlinder.GetComponent<HPbarPos>().distance = new Vector3(0.1f, 0.5f, 0f);
            
            spawnEnemyHP(clone, hpSlinder);

            spawnEnemyCount++;

            yield return new WaitForSeconds(currentWave.spawnTime);
        }
    }
    public void SpawnAnt(int i)
    {
        if (i == 0 && mission.isCool1 == true) return;
        if (i == 1 && mission.isCool2 == true) return;
        if (i == 2 && mission.isCool3 == true) return;

        if (i == 0) mission.isCool1 = true;
        if (i == 1) mission.isCool2 = true;
        if (i == 2) mission.isCool3 = true;

        GameObject clone = Instantiate(AntPrifab[i]);
        Enemy enemy = clone.GetComponent<Enemy>();
        enemy.currentHP = enemy.maxHP;
        enemy.Setup(this, wayPoints);
        enemyList.Add(enemy);

        spawnEnemyHP(clone, AnthpSlinder);

        currentEnemyCount++;


    }
   
    public void DestroyEnemy(DestroyType type, Enemy enemy, EnemyType enemytype)
    {
        if (type == DestroyType.Arrice)
        {
            if (enemytype == EnemyType.Enemy) playerHP.DMG(1f);
            if (enemytype == EnemyType.Ant) playerHP.DMG(10f);
            if (enemytype == EnemyType.Boss) playerHP.DMG(playerHP.CurrentHP);
        }

        if (type == DestroyType.Kill) killCount += 1;

        currentEnemyCount--;
        enemyList.Remove(enemy);
        enemy.DieAnimation();
    }

    private void spawnEnemyHP(GameObject enemy, GameObject slinder)
    {
        GameObject sliderClone = Instantiate(slinder);
        sliderClone.transform.SetParent(canvas);
        sliderClone.transform.localScale = Vector3.one;

        sliderClone.GetComponent<HPbarPos>().Setup(enemy.transform);
        sliderClone.GetComponent<HPbar>().Setup(enemy.GetComponent<Enemy>());
    }


}

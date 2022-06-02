using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrifab;
    [SerializeField] private float spawnTime;
    [SerializeField] private Transform[] wayPoints;
    private List<Enemy> enemyList;

    public List<Enemy> EnemyList => enemyList;

    private void Awake()
    {
        enemyList = new List<Enemy>();
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject clon = Instantiate(enemyPrifab);
            Enemy enemy = clon.GetComponent<Enemy>();
            enemy.Setup(this,wayPoints);
            enemyList.Add(enemy);

            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void DestroyEnemy(Enemy enemy)
    {
        enemyList.Remove(enemy);
        Destroy(enemy.gameObject);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrifab;
    [SerializeField] private GameObject hpSlinder;
    [SerializeField] private Transform[] wayPoints;
    [SerializeField] private Transform canvas;
    [SerializeField] private float spawnTime;
    [SerializeField] private PlayerHP playerHP;
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
            GameObject clone = Instantiate(enemyPrifab);
            Enemy enemy = clone.GetComponent<Enemy>();
            enemy.Setup(this,wayPoints);
            enemyList.Add(enemy);

            spawnEnemyHP(clone);

            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void DestroyEnemy(DestroyType type, Enemy enemy)
    {
        if (type == DestroyType.Arrice) playerHP.DMG(1f);

        enemyList.Remove(enemy);
        Destroy(enemy.gameObject);
    }

    private void spawnEnemyHP(GameObject enemy)
    {
        GameObject sliderClone = Instantiate(hpSlinder);
        sliderClone.transform.SetParent(canvas);
        sliderClone.transform.localScale = Vector3.one;

        sliderClone.GetComponent<HPbarPos>().Setup(enemy.transform);
        sliderClone.GetComponent<HPbar>().Setup(enemy.GetComponent<Enemy>());
    }


}

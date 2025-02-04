using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    private GameObject enemyPrefab;
    public int poolSize = 3;

    [SerializeField] private EnemyManager enemyManager;

    private List<GameObject> enemyPool;



   public GameObject GetEnemy3()
    {
        return enemyPool.ToArray()[enemyPool.Count - 1];
    }

    private void Awake()
    {
        enemyPool = new List<GameObject>();

        

        for (int i = 0; i < poolSize; i++)
        {
            enemyPrefab = enemyManager.enemyPrefabs[i];
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.gameObject.SetActive(false);
            enemyPool.Add(enemy);
        }
    }

    public GameObject GetEnemy(int i)
    {
        if (enemyPool.Count > 0)
        {
            GameObject enemy = enemyPool[i];
            enemy.gameObject.SetActive(true);
            return enemy;
        }
        return null;
    }

    public void ReturnEnemy(GameObject enemy)
    {
        enemy.gameObject.SetActive(false);
    
    }

    public void ShowEnemy(GameObject enemy)
    {
        enemy.gameObject.SetActive(true);
       
    }
}
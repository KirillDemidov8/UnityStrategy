using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> enemyPrefabs;
    private GameObject currentEnemy;
    

    private GameObject enemy3;

    [SerializeField] private EnemyPool enemyPool; 

    private void Start()
    {
      
        enemy3 = enemyPool.GetEnemy3();
        

    }

   
    public void ActivateEnemy(int index)
    {
        if (currentEnemy != null)
        {
            enemyPool.ReturnEnemy(currentEnemy);
        }

        currentEnemy = enemyPool.GetEnemy(index);
        if (currentEnemy != null)
        {
            currentEnemy.transform.position = Vector3.zero;
            enemyPool.ShowEnemy(currentEnemy);
            
        }
    }
    public void PlayEnemy3Animation()
    {
        if (enemy3 != null)
        {

            enemy3.GetComponent<Enemy3>().Attack();
            
        }
    }
}
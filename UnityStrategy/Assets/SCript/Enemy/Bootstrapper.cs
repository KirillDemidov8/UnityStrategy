using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public EnemyManager enemyManager;
    public EnemyPool enemyPool;

    private void Start()
    {
        
        enemyManager = FindObjectOfType<EnemyManager>();
        enemyPool = FindObjectOfType<EnemyPool>();
    }
}
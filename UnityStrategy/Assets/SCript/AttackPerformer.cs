using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPerformer : MonoBehaviour
{
    private IAttackStrategy currentStrategy;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetStrategy(IAttackStrategy strategy)
    {
        currentStrategy = strategy;
    }

    public void PerformAttack()
    {
        currentStrategy?.Attack(anim);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            PerformAttack();
            PerformAction();
        }
    }
    private void PerformAction()
    {
        if (currentStrategy is Attack3)
        {
            
            EnemyManager enemyManager = FindObjectOfType<EnemyManager>();
            if (enemyManager != null)
            {
                enemyManager.PlayEnemy3Animation();
            }
        }
    }

}

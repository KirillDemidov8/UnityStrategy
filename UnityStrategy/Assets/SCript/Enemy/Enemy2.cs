using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    private float attackCooldown = 1f;
    private float lastAttackTime;

    [SerializeField] private GameObject bull;

    protected override void Initialize()
    {
        lastAttackTime = Time.time;
    }

    public override void Attack()
    {
        if (Time.time >= lastAttackTime + attackCooldown)
        {
          
            lastAttackTime = Time.time;
            
        }
    }

    public override void UpdateBehavior()
    {
        Attack();
    }

    public void Shoot()
    {
        
        Debug.Log("Enemy2 shoots!");
        Instantiate(bull, transform.position, Quaternion.identity);

    }
}
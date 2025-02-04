using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemy
{
    private Transform playerTransform;

    protected override void Initialize()
    {
      
    }

    public override void Attack()
    {
        anim.SetTrigger("Attack3");
    }

    public override void UpdateBehavior()
    {
        if (playerTransform != null)
        {
            
            Attack();
        }
    }
}
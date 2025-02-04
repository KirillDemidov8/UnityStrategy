using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    private bool hasAttacked = false;

    protected override void Initialize()
    {
        Attack();
        hasAttacked = true;
    }

    public override void Attack()
    {
        if (!hasAttacked)
        {
            anim.SetTrigger("Attack1");
            hasAttacked = true;
        }
    }

    public override void UpdateBehavior()
    {
        
    }
}
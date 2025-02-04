using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : IAttackStrategy
{
    public void Attack(Animator anim)
    {
        anim.SetTrigger(GetAnimationName());
    }

    public string GetAnimationName()
    {
        return "Attack2";
    }
}
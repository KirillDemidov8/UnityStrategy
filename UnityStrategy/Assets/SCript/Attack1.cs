using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Attack1 : IAttackStrategy
{
    public void Attack(Animator anim)
    {
        anim.SetTrigger(GetAnimationName());
    }

    public string GetAnimationName()
    {
        return "Attack1";
    }
}

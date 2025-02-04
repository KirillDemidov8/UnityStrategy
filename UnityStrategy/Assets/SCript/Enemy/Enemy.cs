using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Animator anim;

    protected virtual void Start()
    {
        anim = GetComponent<Animator>();
        Initialize();
    }

    protected abstract void Initialize();

    public abstract void Attack();

    public abstract void UpdateBehavior();
}

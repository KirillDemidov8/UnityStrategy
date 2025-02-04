using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroTest : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("Attack1");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Attack2");
        }


    }
}

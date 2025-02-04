using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfly : MonoBehaviour
{
    private float speed = 1f;
   
    void Start()
    {
        Destroy(gameObject,3);
    }

   
    void Update()
    {
       transform.Translate(Vector3.left * speed * Time.deltaTime) ;
    }
}

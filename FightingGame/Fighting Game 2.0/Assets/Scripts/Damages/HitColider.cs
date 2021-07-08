using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitColider : MonoBehaviour
{
    public string punchName;
    public float damage;
    public Player owner;
    public Rival rival1;
    public Rival rival2;
    public Rival rival3;
    public Rival rival4;

    void Start()
    {

    }
    
    public void OnTriggerEnter(Collider other)
    {
        Rival somebody = other.gameObject.GetComponent<Rival>();
        //GameObject somebody = GameObject.FindWithTag("Rival");
        
        if (somebody != null && (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.L)))
        {
            Debug.Log("Hit "+somebody+" Punch");
            rival1.TakeDamage(100);
            rival2.TakeDamage(100);
            rival3.TakeDamage(100);
            rival4.TakeDamage(100);
        }
        
    }
}

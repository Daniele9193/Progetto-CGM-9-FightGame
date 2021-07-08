using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitColider : MonoBehaviour
{
    public string punchName;
    public int damageKick = 100;
    public int damagePunch = 50;
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
        
        if (somebody != null && (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L)))
        {
            Debug.Log("Hit " + somebody + " Kick");
            rival1.TakeDamage(damageKick);
            rival2.TakeDamage(damageKick);
            rival3.TakeDamage(damageKick);
            rival4.TakeDamage(damageKick);
        }
        
        
        if (somebody != null && (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.I)))
        {
            Debug.Log("Hit "+somebody+" Punch");
            rival1.TakeDamage(damagePunch);
            rival2.TakeDamage(damagePunch);
            rival3.TakeDamage(damagePunch);
            rival4.TakeDamage(damagePunch);
        }
        
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitColider : MonoBehaviour
{
    public string punchName;
    public float damage;
    public Player owner;
    public Rival rival;
    
    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        Rival somebody = other.gameObject.GetComponent<Rival>();
        //GameObject somebody = GameObject.FindWithTag("Rival");
        //Debug.Log("OnTriggerEnter"+ somebody);
        if (somebody != null)
        {
            Debug.Log("Hit "+somebody+" Punch");
            rival.TakeDamage(100);
        }
    }
}

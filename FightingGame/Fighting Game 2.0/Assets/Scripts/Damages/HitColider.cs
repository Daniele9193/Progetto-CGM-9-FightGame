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
    //private GameObject[] rivalList;

    void Start()
    {
        //rivalList = new GameObject[transform.childCount];
        //for (int i = 0; i < transform.childCount; i++)
            //rivalList[i] = transform.GetChild(i).gameObject;
    }
    
    public void OnTriggerEnter(Collider other)
    {
        Rival somebody = other.gameObject.GetComponent<Rival>();
        //GameObject somebody = GameObject.FindWithTag("Rival");
        
        if (somebody != null)
        {
            Debug.Log("Hit "+somebody+" Punch");
            rival1.TakeDamage(100);
            rival2.TakeDamage(100);
            rival3.TakeDamage(100);
            rival4.TakeDamage(100);
        }
        
    }
}

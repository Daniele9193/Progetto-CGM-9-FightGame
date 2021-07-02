using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitColider : MonoBehaviour
{
    public string punchName;
    public float damage;
    public Player owner;

    private void OnTriggerEnter(Collider other)
    {
        Player somebody = other.gameObject.GetComponent<Player>();
        if (somebody != null && somebody != owner)
        {
            Debug.Log("Hit "+somebody+" Punch");
        }
    }
}

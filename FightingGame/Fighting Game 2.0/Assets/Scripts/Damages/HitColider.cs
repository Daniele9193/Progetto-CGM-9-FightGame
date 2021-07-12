
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitColider : MonoBehaviour
{
    public string punchName;
    public int damageKick = 100;
    public int damagePunch = 50;
    public Player owner;


    void Start()
    {

    }
    
    public void OnTriggerEnter(Collider other)
    {
        
        int random = Random.Range(0, 100);
        
        Rival somebody = other.gameObject.GetComponent<Rival>();
        //GameObject somebody = GameObject.FindWithTag("Rival");
        
        if (somebody != null && (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L)))
        {
            if (random<0)
            {
                owner.rivale.GetComponent<Rival>().TakeDamage(damageKick, true);
            }
            else
            {
                owner.rivale.GetComponent<Rival>().TakeDamage(damageKick*2, false);
            }
        }
        
        
        if (somebody != null && (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.I)))
        {

            if (random<0)
            {
                owner.rivale.GetComponent<Rival>().TakeDamage(damagePunch, true);
            }
            else
            {
                owner.rivale.GetComponent<Rival>().TakeDamage(damagePunch*2, false);
            }
        }
        
        
    }
}

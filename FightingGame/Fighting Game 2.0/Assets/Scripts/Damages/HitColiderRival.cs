using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitColiderRival : MonoBehaviour
{
    public int damageKick = 25;
    public int damagePunch = 10;
    public Rival owner;

    public void OnTriggerEnter(Collider other)
    {
        
        int random = Random.Range(0, 100);
        
        ColiderPlayer somebody = other.gameObject.GetComponent<ColiderPlayer>();

        if (somebody != null && (owner.random==1||owner.random==0) && !owner._anim.GetBool("Knocked") && !owner.player._anim.GetBool("Knocked"))
        {
            if (random<80)
            {
                owner.player.TakeDamage(damageKick, false);
            }
            else
            {
                owner.player.TakeDamage(damageKick*2, true);
            }
        }
        
        
        if (somebody != null && (owner.random==2||owner.random==3) && !owner._anim.GetBool("Knocked") && !owner.player._anim.GetBool("Knocked"))
        {

            if (random<80)
            {
                owner.player.TakeDamage(damagePunch, false);
            }
            else
            {
                owner.player.TakeDamage(damagePunch*2, true);
            }
        }
        
        
    }
}

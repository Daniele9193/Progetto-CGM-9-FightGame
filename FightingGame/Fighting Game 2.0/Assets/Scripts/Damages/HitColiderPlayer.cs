
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitColiderPlayer : MonoBehaviour
{
    public int damageKick = 25;
    public int damagePunch = 10;
    public Player owner;

    public void OnTriggerEnter(Collider other)
    {
        
        int random = Random.Range(0, 100);
        
        ColiderRival somebody = other.gameObject.GetComponent<ColiderRival>();

        if (somebody != null && (Keyboard.current[Key.K].isPressed||Keyboard.current[Key.L].isPressed) && !owner._anim.GetBool("Knocked"))
        {
            if (random<80)
            {
                owner.rival.TakeDamage(damageKick, false);
            }
            else
            {
                owner.rival.TakeDamage(damageKick*2, true);
            }
        }
        
        
        if (somebody != null && (Keyboard.current[Key.J].isPressed||Keyboard.current[Key.I].isPressed) && !owner._anim.GetBool("Knocked"))
        {

            if (random<80)
            {
                owner.rival.TakeDamage(damagePunch, false);
            }
            else
            {
                owner.rival.TakeDamage(damagePunch*2, true);
            }
        }
        
        
    }
}

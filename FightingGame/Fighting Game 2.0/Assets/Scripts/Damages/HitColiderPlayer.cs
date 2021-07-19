
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitColiderPlayer : MonoBehaviour
{
    private int damageKick = 25;
    private int damagePunch = 10;
    public Player owner;

    public void OnTriggerEnter(Collider other)
    {
        
        int random = Random.Range(0, 100);
        
        ColiderRival somebody = other.gameObject.GetComponent<ColiderRival>();

        if (somebody != null && (Keyboard.current[Key.K].isPressed||Keyboard.current[Key.L].isPressed) && !owner._anim.GetBool("Knocked") && !owner.rival._anim.GetBool("Knocked"))
        {
            if (random<95)
            {
                owner.rival.TakeDamage(damageKick, false);
                owner.GainPower(damageKick);
            }
            else
            {
                owner.rival.TakeDamage(damageKick*2, true);
                owner.GainPower(damageKick*2);
            }
        }
        else if (somebody != null && (Keyboard.current[Key.J].isPressed||Keyboard.current[Key.I].isPressed) && !owner._anim.GetBool("Knocked") && !owner.rival._anim.GetBool("Knocked"))
        {

            if (random<95)
            {
                owner.rival.TakeDamage(damagePunch, false);
                owner.GainPower(damagePunch);
            }
            else
            {
                owner.rival.TakeDamage(damagePunch*2, true);
                owner.GainPower(damagePunch*2);
            }
        }
        
        
    }
}

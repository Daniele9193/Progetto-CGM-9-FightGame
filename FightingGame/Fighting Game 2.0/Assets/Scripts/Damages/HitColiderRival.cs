using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitColiderRival : MonoBehaviour
{
    public int damageKick = 100;
    public int damagePunch = 50;
    public Rival owner;

    public void OnTriggerEnter(Collider other)
    {
        
        int random = Random.Range(0, 100);
        
        ColiderPlayer somebody = other.gameObject.GetComponent<ColiderPlayer>();

        if (somebody != null && (Keyboard.current[Key.K].isPressed||Keyboard.current[Key.L].isPressed))
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
        
        
        if (somebody != null && (Keyboard.current[Key.J].isPressed||Keyboard.current[Key.I].isPressed))
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

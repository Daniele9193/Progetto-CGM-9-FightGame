using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damages : MonoBehaviour
{

    public void Punch(Player player, bool parry, bool impenetrable)
    {
        if (impenetrable)
        {
        }
        else
        {
            if (parry)
            {
                player.TakeDamage(5);
            }
            else
            {
                player.TakeDamage(10);
            }
        }
    }

    public void Kick(Player player, bool parry, bool impenetrable)
    {
        if (impenetrable)
        {
        }
        else
        {
            if (parry)
            {
                player.TakeDamage(7);
            }
            else
            {
                player.TakeDamage(15);
            }
        }
    }
}

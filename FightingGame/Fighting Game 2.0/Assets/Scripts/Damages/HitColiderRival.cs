using UnityEngine;

public class HitColiderRival : MonoBehaviour
{
    private int damageKick = 25;
    private int damagePunch = 10;
    public Rival owner;

    public void OnTriggerEnter(Collider other)
    {
        
        int random = Random.Range(0, 100);
        
        ColiderPlayer somebody = other.gameObject.GetComponent<ColiderPlayer>();

        if (somebody != null && (owner.random==1||owner.random==0) && !owner._anim.GetBool("Knocked") && !owner.player._anim.GetBool("Knocked"))
        {
            if (random<95)
            {
                owner.player.TakeDamage(damageKick, false);
                if (!owner.imp)
                {
                    owner.GainPower(damageKick);    
                }
            }
            else
            {
                owner.player.TakeDamage(damageKick*2, true);
                if (!owner.imp)
                {
                    owner.GainPower(damageKick*2);    
                }
            }
        }
        else if (somebody != null && (owner.random==2||owner.random==3) && !owner._anim.GetBool("Knocked") && !owner.player._anim.GetBool("Knocked"))
        {

            if (random<95)
            {
                owner.player.TakeDamage(damagePunch, false);
                {
                    owner.GainPower(damagePunch);
                }
            }
            else
            {
                owner.player.TakeDamage(damagePunch*2, true);
                if (!owner.imp)
                {
                    owner.GainPower(damagePunch*2);    
                }
            }
        }
        
        
    }
}

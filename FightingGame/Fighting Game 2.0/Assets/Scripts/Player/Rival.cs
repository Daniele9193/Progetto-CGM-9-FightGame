using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rival : MonoBehaviour
{
    public int health;
    public int maxHealth= 1000;
    public HealthBar healthBar;
    public PowerBar powerBar;
    public int power=0;
    public int maxPower = 1000;
    public Player player;
    public GameObject loseUI;
    private Animator _anim;


    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        loseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //TakeDamage(1);
        GainPower();
		
        if (health == 0 && _anim.GetBool("Knocked") == false)
        {
            _anim.SetBool("Knocked", true);
            _anim.SetBool("Dead", true);
            player._anim.SetBool("Winner", true);
            loseUI.SetActive(true);

        }
    }
    
    private void GainPower()
    {
        if (power<maxPower)
        {
            power += 1;
            powerBar.SetPower(power);
        }
    }

    public void TakeDamage(int damage)
    {
        if ((health - damage) >= 0)
        {
            health -= damage;
            healthBar.SetHealth(health);
        }
    }
}

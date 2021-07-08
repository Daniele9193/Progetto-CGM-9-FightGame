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
    public Rival rival;
    public float dist = 0.0f;
    private float _speed = 2.0f;
    
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
		Movement();
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

    public void Movement()
    {
        dist = Mathf.Abs(player.transform.position.x - rival.transform.position.x);
        Debug.Log("Distance= " + dist);
        if (dist > 2.0f)
        {
            transform.position += new Vector3(-1 * _speed * Time.deltaTime, 0.0f, 0.0f );
        }

        KickPunch();
    }

    public void KickPunch()
    {
        int random = Random.Range(0, 10);
        Debug.Log(random);
        if (dist <= 2.0f)
        {
            if (random == 0)
            {
                _anim.SetTrigger("KickLeft");
            }
            else if(random==1)
            {
                _anim.SetTrigger("KickRight");
            }
            else if (random==2)
            {
                _anim.SetTrigger("PunchLeft"); 
            }
            else if (random==3)
            {
                _anim.SetTrigger("PunchRight");
            } else
            {
            }
        }
    }
}

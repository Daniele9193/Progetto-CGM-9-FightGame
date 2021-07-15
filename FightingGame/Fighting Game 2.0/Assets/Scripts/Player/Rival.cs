using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rival : MonoBehaviour
{
    public int health;
    private int maxHealth= 1000;
    public HealthBar healthBar;
    public PowerBar powerBar;
    public int power=0;
    private int maxPower = 500;
    public Player player;
    public GameObject loseUI;
    public GameObject characters;
    public GameObject personaggio;
    public GameObject sound;
    public GameObject impIcon;
    public Animator _anim;
    public int random;
    public bool isAttacking = false;
    public bool imp;
    public float dist = 0.0f;
    private float _speed = 2.0f;
    private int index;
    private bool isBlocking = false;
    private GameObject[] characterList;
    
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        loseUI.SetActive(false);
        impIcon.SetActive(false);
        
        index = PlayerPrefs.GetInt("PersonaggioSelezionato");
        characterList = new GameObject[characters.transform.childCount];

        for (int i = 0; i < characters.transform.childCount; i++)
            characterList[i] = characters.transform.GetChild(i).gameObject; 
        
        if (characterList[index])
            personaggio = characterList[index];
        player = personaggio.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
        if (power >= maxPower)
        {
            imp = true;
            impIcon.SetActive(true);
            power = 0;
            powerBar.SetPower(power);
            StartCoroutine(SetImp());
        }
        
        if (health <= 0)
        {
            _anim.SetBool("Knocked", true);
            _anim.SetBool("Dead", true);
            loseUI.SetActive(true);
            sound.SetActive(false);
        }
        
        if (player.health <= 0)
        {
            _anim.SetBool("Winner", true);
            sound.SetActive(false);
        }

        if (!_anim.GetBool("Winner") && !_anim.GetBool("Knocked") && !_anim.GetBool("Dead"))
        {
            KickPunch();
        }
    }
    
    public void GainPower(int p)
    {
        if (power<maxPower)
        {
            power += p;
            powerBar.SetPower(power);
        }
    }

    private void GetUp()
    {
        _anim.SetBool("Knocked", false);
    }

    public void TakeDamage(int damage, bool crit)
    {
        if (!imp)
        {
            if (!isBlocking)
            {
                health -= damage;
                healthBar.SetHealth(health);
                _anim.SetTrigger("Hitted");
                if (crit)
                {
                    _anim.SetBool("Knocked", true);
                    _anim.Play("Knockdown");
                }
            }
            else
            {
                health -= damage / 2;
                healthBar.SetHealth(health);
            }    
        }
    }

    public IEnumerator GettingUp()
    {
        yield return new WaitForSeconds(2.0f);
        GetUp();
    }
    public void Movement()
    {
        if (_anim.GetBool("Knocked") && health > 0 && !_anim.GetBool("Dead"))
        {
            StartCoroutine(GettingUp());
        }
        else
        {
            dist = Mathf.Abs(player.transform.position.x - this.transform.position.x);
            _anim.SetFloat("Distance", dist);
            if (dist > 1.0f && !_anim.GetBool("Winner") && !_anim.GetBool("Knocked"))
            {
                transform.position += new Vector3(-1 * _speed * Time.deltaTime, 0.0f, 0.0f);
                _anim.SetBool("Forward", true);
                _anim.SetBool("Backward", false);
            }
            else if(dist <= 1.0f && !_anim.GetBool("Winner") && !_anim.GetBool("Knocked"))
            {
                transform.position += new Vector3(0.5f * _speed/2 * Time.deltaTime, 0.0f, 0.0f);
                _anim.SetBool("Forward", false);
                _anim.SetBool("Backward", true);
            }

        }
    }

    public void KickPunch()
    {
        _anim.SetBool("Blocking", false);
        random = Random.Range(0, 5);
        _anim.SetInteger("Random", random);
        switch (random)
        {
            case 0:
                _anim.SetTrigger("KickLeft");
                break;
            case 1:
                _anim.SetTrigger("KickRight");
                break;
            case 2:
                _anim.SetTrigger("PunchRight");
                break;
            case 3:
                _anim.SetTrigger("PunchLeft");
                break;
            case 4:
                _anim.SetBool("Blocking", true);
                break;
        }
    }

    public IEnumerator SetImp()
    {
        yield return new WaitForSeconds(5.0f);
        imp = false;
        impIcon.SetActive(false);
    }
    
}

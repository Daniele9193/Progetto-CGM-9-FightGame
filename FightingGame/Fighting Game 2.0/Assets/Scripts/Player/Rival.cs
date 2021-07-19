using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

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
    private int indexArena;
    private float distMax, distMin;
    private bool isBlocking = false;
    private GameObject[] characterList;
    private Vector3 _rivalPos;
    
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        loseUI.SetActive(false);
        impIcon.SetActive(false);
        random = 5;
        index = PlayerPrefs.GetInt("PersonaggioSelezionato");
        indexArena = PlayerPrefs.GetInt("ArenaSelezionata");
        characterList = new GameObject[characters.transform.childCount];

        for (int i = 0; i < characters.transform.childCount; i++)
            characterList[i] = characters.transform.GetChild(i).gameObject; 
        
        if (characterList[index])
            personaggio = characterList[index];
        player = personaggio.GetComponent<Player>();

        switch (indexArena)
        {
            case 0:
                //"TrainingArena"
                distMin = 8.61f;
                distMax = -8.51f;
                break;
            case 1:
                //"SkullArena"
                distMin = 10.38f;
                distMax = -10.11f;
                break;
            case 2:
                //"BoxArena"
                distMin = 10.0f;
                distMax = -10.0f;
                break;
            case 3:
                //"RomanArena"
                distMin = 13.0f;
                distMax = -13.0f;
                break;
            case 4:
                //"HouseArena"
                distMin = 5.93f;
                distMax = -6.07f;
                break;
            case 5:
                //"RuinsArena"
                distMin = 5.0f;
                distMax = -15.5f;
                break;
            case 6:
                //SceneManager.LoadScene("VillageArena");
                break;
            case 7:
                //SceneManager.LoadScene("CityArena");
                break;
            case 8:
                //SceneManager.LoadScene("SkyArena");
                break;
            case 9:
                //SceneManager.LoadScene("HospitalArena");
                break;
            case 10:
                //SceneManager.LoadScene("TempleArena");
                break;
            case 11:
                //SceneManager.LoadScene("VolcanoArena");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _rivalPos = player.transform.position;
        transform.LookAt(_rivalPos);
        
        Movement();
        
        if (power >= maxPower)
        {
            _anim.SetTrigger("PowerUp");
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
    
    public void Movement()
    {
        if (_anim.GetBool("Knocked") && health > 0 && !_anim.GetBool("Dead"))
        {
            StartCoroutine(GettingUp());
        }
        else
        {
            dist = (player.transform.position - transform.position).magnitude;
            _anim.SetFloat("Distance", dist);
            //Debug.Log(transform.position.x);
            if ((transform.position.x - _speed * Time.deltaTime) < distMin && (transform.position.x + _speed * Time.deltaTime) > distMax)
            {
                if (dist > 1.0f &&  !_anim.GetBool("Winner") && !_anim.GetBool("Knocked"))
                {
                    transform.Translate(0.0f,0.0f,_speed * Time.deltaTime);
                    //transform.position += new Vector3(-1 * _speed * Time.deltaTime, 0.0f, 0.0f);
                    _anim.SetBool("Forward", true);
                    _anim.SetBool("Backward", false);
                }
                else if(dist <= 1.0f && !_anim.GetBool("Winner") && !_anim.GetBool("Knocked"))
                {
                    transform.Translate(0.0f,0.0f, -_speed * Time.deltaTime);
                    //transform.position += new Vector3(0.5f * _speed/2 * Time.deltaTime, 0.0f, 0.0f);
                    _anim.SetBool("Forward", false);
                    _anim.SetBool("Backward", true);
                }   
            }
        }
    }

    public void KickPunch()
    {
        _anim.SetBool("Blocking", false);
        random = Random.Range(0, 10);
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
            default:
                random = 5;
                break;
        }
    }

    public IEnumerator SetImp()
    {
        yield return new WaitForSeconds(5.0f);
        imp = false;
        impIcon.SetActive(false);
    }
    
    public IEnumerator GettingUp()
    {
        yield return new WaitForSeconds(1.0f);
        _anim.SetBool("GetUp", true);
        yield return new WaitForSeconds(1.3f);
        _anim.SetBool("Knocked", false);
        _anim.SetBool("GetUp", false);
    }
}

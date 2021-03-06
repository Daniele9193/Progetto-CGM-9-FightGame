using System.Collections;
using UnityEngine;


public class Rival : MonoBehaviour
{
    [HideInInspector]
    public int health;
    [HideInInspector]
    public int power;
    [HideInInspector]
    public GameObject personaggio;
    [HideInInspector]
    public Player player;
    [HideInInspector]
    public int random;
    [HideInInspector]
    public bool imp;
    [HideInInspector] public float dist;
    private int maxHealth= 1000;
    public HealthBar healthBar;
    public PowerBar powerBar;
    private int maxPower = 500;
    public GameObject loseUI;
    public GameObject characters;
    public GameObject impIcon;
    public Animator _anim;
    [SerializeField]
    private float _speed = 2.0f;
    private int index;
    private int indexArena;
    private float distMax, distMin;
    private bool isBlocking;
    private GameObject[] characterList;
    private Vector3 _rivalPos;
    private float sbalzoCritico = 3.0f;
    private AudioManager sound;
    private int NextUpdate = 1;
    private bool morte = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioManager>();
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
                distMin = 10.5f;
                distMax = -1.5f;
                break;
            case 5:
                //"RuinsArena"
                distMin = 10.3f;
                distMax = -10.0f;
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
            sound.Play("powerup");
        }
        
        if (health <= 0)
        {
            _anim.SetBool("Knocked", true);
            _anim.SetBool("Dead", true);
            loseUI.SetActive(true);
            if (morte)
            {
                sound.Play("dead");
                morte = false;
            }
        }
        
        if (player.health <= 0)
        {
            _anim.SetBool("Winner", true);
        }

        if (Time.time >= NextUpdate)
        {
            NextUpdate = Mathf.FloorToInt(Time.time) + 1;
            if (!_anim.GetBool("Winner") && !_anim.GetBool("Knocked") && !_anim.GetBool("Dead"))
            {
                KickPunch();
            }
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
                float delta = Mathf.Abs(transform.position.x - distMin);
                if (crit)
                {
                    if (delta >= sbalzoCritico)
                    {
                        transform.Translate(0.0f,0.0f,-sbalzoCritico); 
                    }
                    _anim.SetBool("Knocked", true);
                    _anim.Play("Knockdown");
                }
                sound.Play("colpitovoce");
                sound.Play("colporicevuto");
            }
            else
            {
                health -= damage / 2;
                healthBar.SetHealth(health);
                sound.Play("block");
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
                if (dist > 1.5f &&  !_anim.GetBool("Winner") && !_anim.GetBool("Knocked"))
                {
                    transform.Translate(0.0f,0.0f,_speed * Time.deltaTime);
                    //transform.position += new Vector3(-1 * _speed * Time.deltaTime, 0.0f, 0.0f);
                    _anim.SetBool("Forward", true);
                    _anim.SetBool("Backward", false);
                }
                else if(dist <= 1.5f && !_anim.GetBool("Winner") && !_anim.GetBool("Knocked"))
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
        isBlocking = false;
        _anim.SetBool("Blocking", false);
        random = Random.Range(0, 10);
        _anim.SetInteger("Random", random);
        
        switch (random)
        {
            case 0:
                if (dist <= 2.5f)
                {
                    _anim.SetTrigger("KickLeft");
                    sound.Play("kick");   
                }
                break;
            case 1:
                if (dist <= 2.5f)
                {
                    _anim.SetTrigger("KickRight");
                    sound.Play("kick");   
                }
                break;
            case 2:
                if (dist <= 2.0f)
                {
                    _anim.SetTrigger("PunchRight");
                    sound.Play("punch");   
                }
                break;
            case 3:
                if (dist <= 2.0f)
                {
                    _anim.SetTrigger("PunchLeft");
                    sound.Play("punch");    
                }
                break;
            case 4:
                _anim.SetBool("Blocking", true);
                isBlocking = true;
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

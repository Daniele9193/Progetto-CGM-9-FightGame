using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [HideInInspector]
    public int health;
    [HideInInspector]
    public int power;
    [HideInInspector]
    public GameObject rivale;
    [HideInInspector]
    public Rival rival;
    [HideInInspector]
    public bool imp;
    
    public int maxHealth= 1000;
    public HealthBar healthBar;
    public PowerBar powerBar;
    public int maxPower = 500;
    public GameObject loseUI;
    public GameObject rivali;
    public GameObject impIcon;
    public Animator _anim;
    
    [SerializeField] 
    private float _speed = 2.0f;
    [SerializeField] private Controls _inputControl;
    private Vector2 _inputMovement;
    private bool forward;
    private bool backward;
    private bool block;
    private bool isBlocking;
    private float sbalzoCritico=3.0f;
    private AudioManager sound;
    private float dist;
    private int index;
    private int indexArena;
    private float distMax, distMin;
    private GameObject[] rivalList;
    private Vector3 _rivalPos;
    private bool morte = true;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        loseUI.SetActive(false);
        impIcon.SetActive(false);
        
        index = PlayerPrefs.GetInt("AvversarioSelezionato");
        indexArena = PlayerPrefs.GetInt("ArenaSelezionata");
        rivalList = new GameObject[rivali.transform.childCount];

        for (int i = 0; i < rivali.transform.childCount; i++)
            rivalList[i] = rivali.transform.GetChild(i).gameObject;
        
        if (rivalList[index])
            rivale=rivalList[index];
        rival = rivale.GetComponent<Rival>();
        
        switch (indexArena)
        {
            case 0:
                //"TrainingArena"
                distMin = -6.5f;
                distMax = 5.91f;
                break;
            case 1:
                //"SkullArena"
                distMin = -10.38f;
                distMax = 10.11f;
                break;
            case 2:
                //"BoxArena"
                distMin = -10.0f;
                distMax = 10.0f;
                break;
            case 3:
                //"RomanArena"
                distMin = -13.0f;
                distMax = 13.0f;
                break;
            case 4:
                //"HouseArena"
                distMin = -1.5f;
                distMax = 10.5f;
                break;
            case 5:
                //"RuinsArena"
                distMin = -10.0f;
                distMax = 10.3f;
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

    private void Awake()
    {
        _inputControl = new Controls();
        sound = GetComponent<AudioManager>();
    }

    private void OnEnable()
    {
        _inputControl.Fighter.Move.performed += OnMovement;
        _inputControl.Fighter.KickLeft.performed += LeftKick;
        _inputControl.Fighter.KickRight.performed += RightKick;
        _inputControl.Fighter.PunchRight.performed += RightPunch;
        _inputControl.Fighter.PunchLeft.performed += LeftPunch;
        _inputControl.Fighter.Defense.performed += Blocking;
        _inputControl.Fighter.Impenetrability.performed += Impenetrability;
        _inputControl.Fighter.Move.Enable();
        _inputControl.Fighter.KickLeft.Enable();
        _inputControl.Fighter.KickRight.Enable();
        _inputControl.Fighter.PunchLeft.Enable();
        _inputControl.Fighter.PunchRight.Enable();
        _inputControl.Fighter.Defense.Enable();
        _inputControl.Fighter.Impenetrability.Enable();
    }
    // Update is called once per frame
    void Update()
    {
        
        Animazione();
        

        dist = Mathf.Abs(transform.position.x - rival.transform.position.x);
        if ((transform.position.x + _inputMovement.x * _speed * Time.deltaTime) > distMin && (transform.position.x + _inputMovement.x * _speed * Time.deltaTime) < distMax && !_anim.GetBool("Dead") && !_anim.GetBool("Knocked") && !_anim.GetBool("Blocking") && dist>1.0f && !_anim.GetBool("Winner"))
        {
            transform.position += new Vector3(_inputMovement.x * _speed * Time.deltaTime, 0.0f, 0.0f );
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

        if (rival.health <= 0)
        {
            _anim.SetBool("Winner", true);
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
                sound.Play("colporicevuto");
                sound.Play("colpitovoce");
            }
            else
            {
                health -= damage / 2;
                healthBar.SetHealth(health);
                sound.Play("block");
            }
        }

    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _inputMovement = value.ReadValue<Vector2>();
        if (!_anim.GetBool("Dead") && _anim.GetBool("Knocked"))
        {
            _anim.SetBool("GetUp", true);
            StartCoroutine(SetGetUp());
        }
    }

    public void RightKick(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("KickRight");
            sound.Play("kick");
        }
    }
    public void LeftKick(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("KickLeft");
            sound.Play("kick");
        }
    }
    public void RightPunch(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("PunchRight"); 
            sound.Play("punch");
        }
        
    }
    public void LeftPunch(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("PunchLeft");
            sound.Play("punch");
        }
    }
    
    public void Blocking(InputAction.CallbackContext value)
    {
        if (!_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            block = !block;
            _anim.SetBool("Blocking", block);
            isBlocking = true;
        }
    }
    
    private void Animazione()
    {
        forward = (_inputMovement.x > 0.1f) ? true: false;
        _anim.SetBool("Forward", forward);
        backward = (_inputMovement.x < -0.1f) ? true: false;
        _anim.SetBool("Backward", backward);

    }

    public void Impenetrability(InputAction.CallbackContext value)
    {
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
    }

    public IEnumerator SetImp()
    {
        yield return new WaitForSeconds(5.0f);
        imp = false;
        impIcon.SetActive(false);
    }
    
    public IEnumerator SetGetUp()
    {
        yield return new WaitForSeconds(1.0f);
        _anim.SetBool("Knocked", false);
        _anim.SetBool("GetUp", false);
    }
}

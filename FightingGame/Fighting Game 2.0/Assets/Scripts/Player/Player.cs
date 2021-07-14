using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int health;
    public int maxHealth= 1000;
    public HealthBar healthBar;
    public PowerBar powerBar;
    public int power=0;
    public int maxPower = 500;
    public GameObject loseUI;
    public GameObject rivale;
    public GameObject rivali;
    public GameObject impIcon;
    public Animator _anim;
    public Rival rival;
    public bool isAttacking = false;
    public bool imp;

    [SerializeField] private float _speed = 2.0f;
    private Vector2 _inputMovement;
    [SerializeField] private Controls _inputControl;
    private bool forward = false;
    private bool backward = false;
    private bool block = false;
    private bool isBlocking = false;

    private float dist = 0.0f;
    private int index;
    private GameObject[] rivalList;
    

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        loseUI.SetActive(false);
        impIcon.SetActive(false);
        
        index = PlayerPrefs.GetInt("AvversarioSelezionato");
        rivalList = new GameObject[rivali.transform.childCount];

        for (int i = 0; i < rivali.transform.childCount; i++)
            rivalList[i] = rivali.transform.GetChild(i).gameObject;
        
        if (rivalList[index])
            rivale=rivalList[index];
        rival = rivale.GetComponent<Rival>();
        
    }

    private void Awake()
    {
        _inputControl = new Controls();
    }

    private void OnEnable()
    {
        _inputControl.Fighter.Move.performed += OnMovement;
        _inputControl.Fighter.KickLeft.performed += LeftKick;
        _inputControl.Fighter.KickRight.performed += RightKick;
        _inputControl.Fighter.PunchRight.performed += RightPunch;
        _inputControl.Fighter.PunchLeft.performed += LeftPunch;
        _inputControl.Fighter.Move.Enable();
        _inputControl.Fighter.KickLeft.Enable();
        _inputControl.Fighter.KickRight.Enable();
        _inputControl.Fighter.PunchLeft.Enable();
        _inputControl.Fighter.PunchRight.Enable();
    }
    // Update is called once per frame
    void Update()
    {
        Animazione();
        
        //Debug.Log(health);
        
        dist = Mathf.Abs(this.transform.position.x - rival.transform.position.x);
        
        if (!_anim.GetBool("Dead") && !_anim.GetBool("Knocked") && !_anim.GetBool("Blocking") && dist>1.0f && !_anim.GetBool("Winner"))
        {
            transform.position += new Vector3(_inputMovement.x * _speed * Time.deltaTime, 0.0f, 0.0f );
        } 

		
		if (health <= 0)
        {
			_anim.SetBool("Knocked", true);
            _anim.SetBool("Dead", true);
            loseUI.SetActive(true);
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

    public void OnMovement(InputAction.CallbackContext value)
    {
        _inputMovement = value.ReadValue<Vector2>();
        if (!_anim.GetBool("Dead") && _anim.GetBool("Knocked"))
        {
            _anim.SetBool("Knocked", false);
            _anim.Play("GetUp");
        }
    }

    public void RightKick(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("KickRight");
            isAttacking = true;
        }
    }
    public void LeftKick(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("KickLeft");
            isAttacking = true;
        }
    }
    public void RightPunch(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("PunchRight");  
            isAttacking = true;
        }
        
    }
    public void LeftPunch(InputAction.CallbackContext value)
    {
        if (value.performed && !_anim.GetBool("Knocked") && !_anim.GetBool("Winner"))
        {
            _anim.SetTrigger("PunchLeft");
            isAttacking = true;
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
            imp = true;
            impIcon.SetActive(true);
            power = 0;
            powerBar.SetPower(power);
            StartCoroutine(SetImp());
        }
    }

    public IEnumerator SetImp()
    {
        yield return new WaitForSeconds(5.0f);
        imp = false;
        impIcon.SetActive(false);
    }
}

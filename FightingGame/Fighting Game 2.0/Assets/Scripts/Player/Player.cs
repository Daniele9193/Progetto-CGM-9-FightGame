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
    public int maxPower = 1000;
    public GameObject loseUI;
    public GameObject rivale;
    public GameObject rivali;
    public Animator _anim;
    public Rival rival;
    
    [SerializeField] private float _speed = 2.0f;
    private Vector2 _inputMovement;
    [SerializeField] private Controls _inputControl;
    private bool forward = false;
    private bool backward = false;
    private bool block = false;
    
    private bool isKicking = false;
    private bool isPunching = false;
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
        
        dist = Mathf.Abs(this.transform.position.x - rival.transform.position.x);
        
        if (_anim.GetBool("Dead") == false && _anim.GetBool("Knocked") == false && _anim.GetBool("Blocking")==false && dist>1.0f)
        {
            transform.position += new Vector3(_inputMovement.x * _speed * Time.deltaTime, 0.0f, 0.0f );
        }
        
        GainPower();
		
		if (health == 0 && _anim.GetBool("Knocked") == false)
        {
			_anim.SetBool("Knocked", true);
            _anim.SetBool("Dead", true);
            rival._anim.SetBool("Winner", true);
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

    public void TakeDamage(int damage, bool crit)
    {
        if ((health - damage) >= 0)
        {
            health -= damage;
            healthBar.SetHealth(health);
        }

        if (crit)
        {
            _anim.SetBool("Knocked", true);
            _anim.Play("Knockdown");
        }
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _inputMovement = value.ReadValue<Vector2>();
    }

    public void RightKick(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            _anim.SetTrigger("KickRight");   
        }
    }
    public void LeftKick(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            _anim.SetTrigger("KickLeft");   
        }
    }
    public void RightPunch(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            _anim.SetTrigger("PunchRight");   
        }
        
    }
    public void LeftPunch(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            _anim.SetTrigger("PunchLeft");
        }
    }
    
    public void Blocking(InputAction.CallbackContext value)
    {
        block = !block;
        _anim.SetBool("Blocking", block);
    }
    
    private void Animazione()
    {
        forward = (_inputMovement.x > 0.1f) ? true: false;
        _anim.SetBool("Forward", forward);
        backward = (_inputMovement.x < -0.1f) ? true: false;
        _anim.SetBool("Backward", backward);

    }
}

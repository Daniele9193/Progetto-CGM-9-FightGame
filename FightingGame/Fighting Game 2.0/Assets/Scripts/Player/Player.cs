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
    
    [SerializeField] private float _speed = 2.0f;
    private Vector2 _inputMovement;
    [SerializeField] private Controls _inputControl;
    private Animator _anim;
    private bool forward = false;
    private bool backward = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
		health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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
        
        if (_anim.GetBool("Dead") == false && _anim.GetBool("Knocked") == false && _anim.GetBool("Blocking")==false)
        {
            transform.position += new Vector3(_inputMovement.x * _speed * Time.deltaTime, 0.0f, 0.0f );
        }
		
		TakeDamage(1);
        GainPower();
    
	}
    

	void GainPower()
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

    public void OnMovement(InputAction.CallbackContext value)
    {
        _inputMovement = value.ReadValue<Vector2>();
        if (_anim.GetBool("Knocked") == true)
        {
            _anim.SetBool("Knocked", false);
        }
    }
    public void RightKick(InputAction.CallbackContext value)
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _anim.SetTrigger("KickRight");   
        }
    }
    public void LeftKick(InputAction.CallbackContext value)
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            _anim.SetTrigger("KickLeft");   
        }

    }
    public void RightPunch(InputAction.CallbackContext value)
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            _anim.SetTrigger("PunchRight");   
        }
        
    }
    public void LeftPunch(InputAction.CallbackContext value)
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            _anim.SetTrigger("PunchLeft");
        }
    }
    private void Animazione()
    {
        forward = (_inputMovement.x > 0.1f) ? true: false;
        _anim.SetBool("Forward", forward);
        backward = (_inputMovement.x < -0.1f) ? true: false;
        _anim.SetBool("Backward", backward);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 0.005f;
    private Vector2 _inputMovement;
    [SerializeField] private InputControl _inputControl;
    private Animator _anim;
    private bool movimentoavanti = false;
    private bool movimentoindietro = false;
    //private bool blocco = false;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void Awake()
    {
        _inputControl = new InputControl();
    }
    
    private void OnEnable()
    {
        _inputControl.FighterControl.Move.performed += OnMovement;
        _inputControl.FighterControl.Kick.performed += KickLeft;
        _inputControl.FighterControl.Punch.performed += RightPunch;
        _inputControl.FighterControl.Block.performed += IsBlocking;
        _inputControl.FighterControl.Block.canceled += IsBlocking;
        _inputControl.FighterControl.Move.Enable();
        _inputControl.FighterControl.Kick.Enable();
        _inputControl.FighterControl.Punch.Enable();
        _inputControl.FighterControl.Block.Enable();
    }

    private void Update()
    {
        Animazione();

        if (_anim.GetBool("IsDead") == false && _anim.GetBool("IsKnocked") == false && _anim.GetBool("IsBlocking")==false)
        {
            transform.position += new Vector3(_inputMovement.x * _speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        _inputMovement = value.ReadValue<Vector2>();
        if (_anim.GetBool("IsKnocked") == true)
        {
           _anim.SetBool("IsKnocked", false);
        }
    }

    public void KickLeft(InputAction.CallbackContext value)
    {
        _anim.SetTrigger("LeftKick");
    }

    public void RightPunch(InputAction.CallbackContext value)
    {
        _anim.SetTrigger("RightPunch");
    }

    public void IsBlocking(InputAction.CallbackContext value)
    {
        _anim.SetBool("IsBlocking", value.ReadValueAsButton());
    }
    
    private void Animazione()
    {
        movimentoavanti = (_inputMovement.x > 0.1f) ? true: false;
        _anim.SetBool("MoveForward", movimentoavanti);
        movimentoindietro = (_inputMovement.x < -0.1f) ? true: false;
        _anim.SetBool("MoveBackward", movimentoindietro);
    }
}

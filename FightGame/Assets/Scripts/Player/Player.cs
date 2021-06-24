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
    private bool isDead = false;
    private bool isWin = false;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    
    void OnEnable()
    {
        _inputControl.FighterControl.Move.performed += OnMovement;
        _inputControl.FighterControl.Move.Enable();
    }
    

    private void Update()
    {
        Animazione();
        if (_anim.GetBool("IsDead") == false && _anim.GetBool("IsKnocked") == false)
        {
            transform.position += new Vector3(_inputMovement.x * _speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }

    private void OnMovement(InputAction.CallbackContext value)
    {
        _inputMovement = value.ReadValue<Vector2>();
        if (_anim.GetBool("IsKnocked") == true)
        {
            _anim.SetBool("IsKnocked", false);
        }
    }

    private void Animazione()
    {
        movimentoavanti = (_inputMovement.x > 0.1f) ? true: false;
        _anim.SetBool("MoveForward", movimentoavanti);
        movimentoindietro = (_inputMovement.x < -0.1f) ? true: false;
        _anim.SetBool("MoveBackward", movimentoindietro);
    }
}

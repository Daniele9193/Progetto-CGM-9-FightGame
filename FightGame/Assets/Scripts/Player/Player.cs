using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 0.1f;
    private Vector2 _inputMovement;
    [SerializeField] private InputControl _inputControl;
    private Animator _anim;
    private bool movimento = false;

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
        transform.position += new Vector3(_inputMovement.x * _speed * Time.deltaTime, 0.0f, 0.0f);
    }

    private void OnMovement(InputAction.CallbackContext value)
    {
        Debug.Log(value.control.displayName);
        //movimento = true;
        _inputMovement = value.ReadValue<Vector2>();

        //_anim.SetTrigger("MoveForward");
        Debug.Log(_inputMovement);
    }

    private void Animazione()
    {
        movimento = (_inputMovement.x < -0.1f || _inputMovement.x > 0.1f || _inputMovement.y < -0.1f ||
                     _inputMovement.y > 0.1f) ? true: false;
    }
}

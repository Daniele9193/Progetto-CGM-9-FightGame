using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector3 rawInputMovement;
    private int speed = 10;

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 inputMovement = value.ReadValue<Vector2>();
        rawInputMovement = new Vector3(0, 0, inputMovement.x*speed*Time.deltaTime);
        
        Debug.Log("Log: " + rawInputMovement);
        transform.Translate(rawInputMovement);
    }
}

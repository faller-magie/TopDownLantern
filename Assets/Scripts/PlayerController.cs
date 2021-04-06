using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   public float speed = 8;
   public float maxSpeed = 40;

    private Controls controls;
    private Vector2 movement;
    private Rigidbody2D myRB;
    
    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Player.Move.performed += OnMovePerformed;
        controls.Player.Move.canceled += OnMoveCanceled;
    }
    private void OnMovePerformed(InputAction.CallbackContext obj)
    {
        movement = obj.ReadValue<Vector2>();
        Debug.Log(movement);
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
        movement = Vector2.zero;
    }
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

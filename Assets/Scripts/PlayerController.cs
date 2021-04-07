using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   [SerializeField] float speed = 0f;
   

    private Controls controls;
    private Vector2 movement;
    private Rigidbody2D myRB;
    
    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Player.Movement.performed += OnMovePerformed;
        controls.Player.Movement.canceled += OnMoveCanceled;
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
    void FixedUpdate()
    {
        Vector2 moveInput = controls.Player.Movement.ReadValue<Vector2>();
        myRB.velocity = moveInput * speed;
    }
}

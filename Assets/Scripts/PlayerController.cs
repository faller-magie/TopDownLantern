using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float speed = 8f;
    private Controls controls;
    private Vector2 movement;
    //private float movement;
    private Rigidbody2D myRB;

    private SpriteRenderer spriteRenderer;

    public float lightIntensity;


    public float maxIntensity;
    public float minIntensity;

    private Animator anim;

    public GameObject imageWin;

    private Animator playerMove;

    private bool HitWall = false;

    public bool GetKey = false;
    
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
        //movement = obj.ReadValue<float>();
        Debug.Log(movement);
        spriteRenderer.flipX = (movement.x < 0);
        /*if (movement.x < 0f)
        {
            spriteRenderer.flipX = true;
        }
        else if (movement.x > 0f)
        {
            spriteRenderer.flipX = false;
        }*/
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
        movement = Vector2.zero;
        //movement = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        myRB = GetComponent<Rigidbody2D>();

        lightIntensity = maxIntensity;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveInput = controls.Player.Movement.ReadValue<Vector2>();
        myRB.velocity = moveInput * speed;
    }

    void Update()
    {
        if(lightIntensity > minIntensity)
        {
            lightIntensity-=(Time.deltaTime*0.1f);
        }
        anim.SetFloat("L", lightIntensity);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Mur"))
        {
            HitWall = true;
        }

        if(other.gameObject.tag == "Porte")
        {
            if(GetKey == true)
            {
                Destroy(other.gameObject);
            }
        }

        if(other.gameObject.tag == "Frigo")
        {
            imageWin.SetActive(true);
        }
    }
}

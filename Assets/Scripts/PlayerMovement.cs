using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using InputMapping;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //public CharacterController2D controller;
    //public Animator animator;

    public float runSpeed = 40f;

    Rigidbody2D rb;
    PlayerInputActions inputAction;
    CharacterController2D controller;
    Animator animur;

    Vector2 movementInput;

    float horizontalMove = 0f;
    bool jump = false;

    private void Awake()
    {
        SetPlayerInputActions();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controller = GetComponent<CharacterController2D>();
        animur = GetComponent<Animator>();

        var allGamepads = Gamepad.all;
        foreach (var gamepad in allGamepads)
            Debug.Log(gamepad);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = movementInput.x * runSpeed;
        animur.SetFloat("Speed", Mathf.Abs(horizontalMove));
        animur.SetBool("IsFalling", controller.IsFalling());
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, false, jump);
        jump = false;
        /*
        if (controller.IsGrounded() && movementInput.x == 0.0f)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        */
    }

    public void OnLanding()
    {
        animur.SetBool("IsJumping", false);
        animur.SetBool("IsFalling", false);
    }

    void SetPlayerInputActions()
    {
        inputAction = new PlayerInputActions();

        inputAction.PlayerController.Movement.performed += ctx => Movement(ctx);
        inputAction.PlayerController.Movement.canceled += ctx => Movement(ctx);

        inputAction.PlayerController.Jump.started += ctx => Jump(ctx);
        //inputAction.PlayerController.Jump.canceled += ctx => Jump(ctx);
        
        inputAction.PlayerController.Dash.started += ctx => Dash();
        inputAction.PlayerController.BasicAttack.started += ctx => BasicAttack();
        /*
        inputAction.PlayerController.ActivateColorShift.started += ctx => ActivateColorShift();
        inputAction.PlayerController.ShiftColorLeft.started += ctx => ShiftColorLeft();
        inputAction.PlayerController.ShiftColorRight.started += ctx => ShiftColorRight();
        inputAction.PlayerController.MapToggle.started += ctx => MapToggle();
        inputAction.PlayerController.Pause.started += ctx => Pause();
        */

        //inputAction.PlayerController.Jump.canceled += ctx => jumpInput = ctx.ReadValueAsButton();
        // Functions can also be called in ctx
    }

    void OnEnable()
    {
        inputAction.Enable();
    }

    void OnDisable()
    {
        inputAction.Disable();
    }

    void Movement(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
    }

    void Jump(InputAction.CallbackContext ctx)
    {
        jump = ctx.ReadValueAsButton();
        animur.SetBool("IsJumping", true);
    }

    void Dash()
    {

    }

    void BasicAttack()
    {
        animur.SetTrigger("Attack");
    }
}

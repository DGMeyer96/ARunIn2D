using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using InputMapping;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 1.0f;
    [SerializeField] private float _jumpHeight = 1.0f;
    PlayerInputActions inputAction;
    CharacterController2D controller;
    Animator animur;

    /// <summary>The stored input for movement.</summary>
    Vector2 movementInput;
    bool jump = false;
    bool crouch = false;

    private void Awake()
    {
        SetPlayerInputActions();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        animur = GetComponent<Animator>();
        var allGamepads = Gamepad.all;

        foreach (var gamepad in allGamepads)
            Debug.Log(gamepad);
    }

    void OnEnable()
    {
        inputAction.Enable();
    }

    /// <summary>
    /// Called when component on the attached object is disabled.
    /// </summary>
    void OnDisable()
    {
        inputAction.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        //CharacterMovement();
        controller.Move(movementInput.x, crouch, jump);
        if (movementInput.x != 0)
        {
            animur.SetBool("Moving", true);
        }
        else
        {
            animur.SetBool("Moving", false);
        }
    }

    void SetPlayerInputActions()
    {
        inputAction = new PlayerInputActions();

        inputAction.PlayerController.Movement.performed += ctx => Movement(ctx);
        inputAction.PlayerController.Movement.canceled += ctx => Movement(ctx);

        inputAction.PlayerController.Jump.started += ctx => Jump(ctx);
        inputAction.PlayerController.Jump.canceled += ctx => Jump(ctx);
        inputAction.PlayerController.Dash.started += ctx => Dash();
        inputAction.PlayerController.BasicAttack.started += ctx => BasicAttack();
        inputAction.PlayerController.ActivateColorShift.started += ctx => ActivateColorShift();
        inputAction.PlayerController.ShiftColorLeft.started += ctx => ShiftColorLeft();
        inputAction.PlayerController.ShiftColorRight.started += ctx => ShiftColorRight();
        inputAction.PlayerController.MapToggle.started += ctx => MapToggle();
        inputAction.PlayerController.Pause.started += ctx => Pause();


        //inputAction.PlayerController.Jump.canceled += ctx => jumpInput = ctx.ReadValueAsButton();
        // Functions can also be called in ctx
    }

    void Movement(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
        Debug.Log("Movement: " + movementInput);
    }

    /// <summary>
    /// Used to set jump input.
    /// </summary>
    void Jump(InputAction.CallbackContext ctx)
    {
        jump = ctx.ReadValueAsButton();
        Debug.Log("Jump");
        //= ctx.ReadValueAsButton
    }

    /// <summary>
    /// Used to set dash input.
    /// </summary>
    void Dash()
    {
        Debug.Log("Dash");
    }

    /// <summary>
    /// Used to set basic attack input.
    /// </summary>
    void BasicAttack()
    {
        Debug.Log("BasicAttack");
    }

    /// <summary>
    /// Used to set activate color shift input.
    /// </summary>
    void ActivateColorShift()
    {
        Debug.Log("ActivateColorShift");
    }

    /// <summary>
    /// Used to set color shifting input.
    /// </summary>
    void ShiftColorLeft()
    {
        Debug.Log("ShiftColorLeft");
    }

    /// <summary>
    /// Used to set color shifting input.
    /// </summary>
    void ShiftColorRight()
    {
        Debug.Log("ShiftColorRight");
    }

    /// <summary>
    /// Used to set map toggle input.
    /// </summary>
    void MapToggle()
    {
        Debug.Log("MapToggle");
    }

    /// <summary>
    /// Used to set pause input.
    /// </summary>
    void Pause()
    {
        Debug.Log("Pause");
    }

    void CharacterMovement()
    {
        transform.Translate(new Vector2(movementInput.x, 0.0f) * _movementSpeed * Time.deltaTime);
    }
}

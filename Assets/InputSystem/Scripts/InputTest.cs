using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputMapping;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Switch;

public class InputTest : MonoBehaviour
{
    /// <summary>The input action object for the player.</summary>
    PlayerInputActions inputAction;

    /// <summary>The stored input for movement.</summary>
    Vector2 movementInput;

    /// <summary>
    /// Called before start. Set any instances here.
    /// </summary>
    void Awake()
    {
        SetPlayerInputActions();
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        var allGamepads = Gamepad.all;

        foreach (var gamepad in allGamepads)
            Debug.Log(gamepad);
    }

    /// <summary>
    /// Update is called once per frame 
    /// </summary>
    void Update()
    {
        
    }

    /// <summary>
    /// Called when component on the attached object is enabled.
    /// </summary>
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

    /// <summary>
    /// Used to set the PlayerInputActions information for input.
    /// </summary>
    void SetPlayerInputActions()
    {
        inputAction = new PlayerInputActions();

        //inputAction.PlayerController.AnyInput.started += ctx => AnyInputPressed();
        //inputAction.PlayerController.AnyInput.canceled += ctx => AnyInputReleased();
        
        inputAction.PlayerController.Movement.performed += ctx => Movement(ctx);
        inputAction.PlayerController.Movement.canceled += ctx => Movement(ctx);

        inputAction.PlayerController.Jump.started += ctx => Jump();
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

    /// <summary>
    /// Used to see if any input is pressed.
    /// </summary>
    void AnyInputPressed()
    {
        Debug.Log("AnyInputPressed");
    }

    /// <summary>
    /// Used to see if any input is released.
    /// </summary>
    void AnyInputReleased()
    {
        Debug.Log("AnyInputReleased");
    }

    /// <summary>
    /// Used to set movement input.
    /// </summary>
    /// <param name="ctx">The InputAction.CallbackContext that is used to get read input information.</param>
    void Movement(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
        Debug.Log("Movement: " + movementInput);
    }

    /// <summary>
    /// Used to set jump input.
    /// </summary>
    void Jump()
    {
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

    /// <summary>
    /// Another way of input
    /// </summary>
    /// <param name="value"></param>
    void OnMovement(InputValue value)
    {

    }
}

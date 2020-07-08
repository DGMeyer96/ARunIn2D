using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputMapping;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    PlayerInputActions inputAction;
    Vector2 movementInput;

    bool jumpInput = false;

    /// <summary>
    /// Called before start. Set any instances here.
    /// </summary>
    void Awake()
    {
        inputAction = new PlayerInputActions();
        inputAction.PlayerController.Movement.performed += ctx => Movement(ctx);
        inputAction.PlayerController.Movement.canceled += ctx => Movement(ctx);
        inputAction.PlayerController.Jump.started += ctx => Jump();
        //inputAction.PlayerController.Jump.canceled += ctx => jumpInput = ctx.ReadValueAsButton();
        // Functions can also be called in ctx
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// Update is called once per frame 
    /// </summary>
    void Update()
    {
        Debug.Log("Movement: " + movementInput);
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

    void Movement(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
        Debug.Log("Movement: " + movementInput);
    }

    void Jump()
    {
        Debug.Log("Jump");
        //= ctx.ReadValueAsButton
    }

    void OnMovement(InputValue value)
    {

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using InputMapping;
using UnityEditor.U2D.Path.GUIFramework;
using System.Data;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float RunSpeed = 40f;
    [SerializeField] private float AttackSpeed = 0.333f;
    [SerializeField] private Vector2 AttackRange = new Vector2(1.0f, 1.0f);
    [SerializeField] private float DashModifier = 2.5f;
    [SerializeField] private float DashCooldown = 1.0f;

    [SerializeField] private GameObject HitEffect;
    [SerializeField] private GameObject LandEffect;
    [SerializeField] private GameObject JumpEffect;

    [SerializeField] private LayerMask EnemyLayer;

    [SerializeField] private Transform AttackPosition;

    Rigidbody2D _Rigidbody;
    PlayerInputActions _InputAction;
    CharacterController2D _Controller;
    Animator _Animur;

    Vector2 _MovementInput;

    float _HorizontalMove = 0f;
    bool _Jump = false;
    bool _Input = false;
    bool _Dash = false;

    float _NextAttack = 0.0f;
    float _NextDash = 0.0f;

    private void Awake()
    {
        SetPlayerInputActions();
    }

    // Start is called before the first frame update
    void Start()
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
        _Controller = GetComponent<CharacterController2D>();
        _Animur = GetComponent<Animator>();

        var allGamepads = Gamepad.all;
        foreach (var gamepad in allGamepads)
            Debug.Log(gamepad);
    }

    // Update is called once per frame
    void Update()
    {
        //Get movement _Input and modify by our RunSpeed
        _HorizontalMove = _MovementInput.x * RunSpeed;
        
        //Check if we are dashing, if so increase speed for _Dash
        if(_Dash)
        {
            _HorizontalMove *= DashModifier;
        }
        
        //Set the movement animation float
        _Animur.SetFloat("Speed", Mathf.Abs(_HorizontalMove));

        //If we are falling, stop jumping animation, play falling aniamtion
        if (_Controller.IsFalling())
        {
            _Animur.SetBool("IsFalling", true);
            _Animur.SetBool("IsJumping", false);
        }
        else
        {
            _Animur.SetBool("IsFalling", false);
        }
            
    }

    private void FixedUpdate()
    {
        _Controller.Move(_HorizontalMove * Time.deltaTime, false, _Jump);

        /*
        if (_Controller.IsGrounded() && _MovementInput.x == 0.0f && !_Animur.GetBool("IsJumping"))
        {
            _Rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            _Rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        */
        /*
        if(_Controller.IsGrounded())
        {
            _Rigidbody.gravityScale = 0;
        }
        else
        {
            _Rigidbody.gravityScale = 3;
        }
        */

        //Reset the _Jump _Input
        _Jump = false;
    }

    public void OnLanding()
    {
        //_Animur.SetBool("IsJumping", false);
        //Reset the falling bool so we shift to idle or run animation
        _Animur.SetBool("IsFalling", false);
        //Spawn the Landing effect
        Instantiate(LandEffect, transform);
    }

    void SetPlayerInputActions()
    {
        _InputAction = new PlayerInputActions();

        _InputAction.PlayerController.Movement.performed += ctx => Movement(ctx);
        _InputAction.PlayerController.Movement.canceled += ctx => Movement(ctx);

        _InputAction.PlayerController.Jump.started += ctx => Jump(ctx);
        //_InputAction.PlayerController._Jump.canceled += ctx => _Jump(ctx);
        
        _InputAction.PlayerController.Dash.started += ctx => Dash();
        _InputAction.PlayerController.BasicAttack.performed += ctx => BasicAttack();
        /*
        _InputAction.PlayerController.ActivateColorShift.started += ctx => ActivateColorShift();
        _InputAction.PlayerController.ShiftColorLeft.started += ctx => ShiftColorLeft();
        _InputAction.PlayerController.ShiftColorRight.started += ctx => ShiftColorRight();
        _InputAction.PlayerController.MapToggle.started += ctx => MapToggle();
        _InputAction.PlayerController.Pause.started += ctx => Pause();
        */

        //_InputAction.PlayerController._Jump.canceled += ctx => jumpInput = ctx.ReadValueAsButton();
        // Functions can also be called in ctx
    }

    void OnEnable()
    {
        _InputAction.Enable();
    }

    void OnDisable()
    {
        _InputAction.Disable();
    }

    void Movement(InputAction.CallbackContext ctx)
    {
        _MovementInput = ctx.ReadValue<Vector2>();
    }

    void Jump(InputAction.CallbackContext ctx)
    {
        //Set bool based on _Input
        _Jump = ctx.ReadValueAsButton();
        //Set the animation to play
        _Animur.SetBool("IsJumping", true);

        //Check if the player is grounded, if so play the _Jump effect
        if(_Controller.IsGrounded())
        {
            Instantiate(JumpEffect, transform);
        }
    }

    void Dash()
    {
        //Check if cooldown is done and the player is tryiing to move
        if(Time.time > _NextDash && _MovementInput.x != 0.0f)
        {
            //Set _Dash bool
            _Dash = true;
            //Trigger the animation
            _Animur.SetTrigger("_Dash");
            //Invoke DashEnd() after the animation has finished (it's 0.5 sec long) 
            Invoke("DashEnd", 0.5f);

            //Reset the cooldown
            _NextDash = Time.time + DashCooldown;
        }
    }

    void DashEnd()
    {
        //Reset the _Dash bool
        _Dash = false;
    }

    void BasicAttack()
    {
        //Check if attack cooldown over, prevents spamming attack
        if(Time.time > _NextAttack)
        {
            //Play the attack animation
            _Animur.SetTrigger("Attack");

            //Check if there are any colliders on the Enemy Layer
            Collider2D[] damage = Physics2D.OverlapBoxAll(AttackPosition.position, AttackRange, EnemyLayer);
            //Iterate through list of enemies
            for(int i = 0; i < damage.Length; i++)
            {
                //Check if there is a tag for enemy, can adjust this later to specific enemy types
                if(damage[i].tag == "Enemy")
                {
                    //Damage the anemy, having issue where the enemy can take multiple hits in a single swing, needs fixing
                    damage[i].GetComponentInChildren<EnemyControllerBase>().TakeDamage(GetComponent<PlayerStats>().Damage);
                    //Spawn the hit effect
                    Instantiate(HitEffect, damage[i].transform);
                }
            }
            //Reset the cooldown
            _NextAttack = Time.time + AttackSpeed;
        } 
    }

    public void TakeDamage(int damage)
    {
        //Take damage
        GetComponent<PlayerStats>().Health -= damage;
        //Debug player health
        Debug.Log("Player Health = " + GetComponent<PlayerStats>().Health);
        
        if(GetComponent<PlayerStats>().Health <= 0)
        {
            Death();
        }
        else
        {
            //Play the hit animation
            _Animur.SetTrigger("Hit");
        }
    }

    void Death()
    {
        //Play the death animation
        _Animur.SetBool("Death", true);
        //Disable the player ability to move
        GetComponent<CharacterController2D>().enabled = false;
        //Destroy the gameobject once the aniamtion is done playing
        Destroy(gameObject, 0.7f);

        //Call End Game Screen
        //This will also hide the player model
    }
}

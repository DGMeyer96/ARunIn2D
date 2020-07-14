using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool run = false;
    bool crouch = false;
    bool left = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetAxisRaw("Horizontal") < 0.0f)
        {
            run = true;
            left = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0.0f)
        {
            run = true;
            left = false;
        
        }
        else
        {
            run = false;
            left = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        animator.SetBool("Run", run);
        animator.SetBool("Jump", jump);
        
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

        if (left == true)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        animator.SetBool("Run", run);
        animator.SetBool("Jump", jump);
    }
}

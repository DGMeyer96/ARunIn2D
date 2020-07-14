using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 10;
    bool jumping = false;
    bool isGrounded;
    public EnemyDetection eD;

    void Start()
    {
        isGrounded = eD.m_Grounded;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update()
    {
        isGrounded = eD.m_Grounded;
        //Debug.Log(isGrounded);
        if (jumping && !isGrounded)
        {
            jumping = false;
            //isGrounded = true;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb.freezeRotation = true;
            Debug.Log(isGrounded);
        }
        else
        {
            //rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        if(!isGrounded)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.freezeRotation = true;
            rb.gravityScale = 100;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "EnemyJump")
        {
            Debug.Log("Plese Jump please");
            jumping = true;
            isGrounded = false;
            rb.constraints = RigidbodyConstraints2D.None;
            Jump();
        }
    }

    void Jump()
    {
        Debug.Log("I am jumping");
        rb.constraints = RigidbodyConstraints2D.None;
        rb.AddForce(Vector2.up * jumpForce);
    }
}

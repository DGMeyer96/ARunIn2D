using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyDetection : MonoBehaviour
{
    public AIDestinationSetter destSet;
    bool playerTargeted = false;
    Rigidbody2D rb;
    public float timer = 5.0f;
    public Transform startingPoint;

    public EnemyGroundMove enemyMoveG;

    [SerializeField] private LayerMask m_WhatIsGround;							// A mask determining what is ground to the character
	[SerializeField] private Transform m_GroundCheck;							// A position marking where to check if the player is grounded.

    const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
    public bool m_Grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(destSet.target != null && playerTargeted)
        {
            timer -= Time.deltaTime;
            if(timer <= 0.0f)
            {
                destSet.target = startingPoint;
                timer = 5.0f;
            }
        }

        //if(enemyMoveG.target != null && playerTargeted == true)
        //{
        //    timer -= Time.deltaTime;
        //        if(timer <= 0.0f)
        //        {
        //            enemyMoveG.target = startingPoint;
        //            timer = 5.0f;
        //        playerTargeted = false;
        //        }
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            destSet.target = collision.transform;
            //enemyMoveG.target = collision.transform;
            playerTargeted = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            destSet.target = collision.transform;
            //enemyMoveG.target = collision.transform;
            playerTargeted = true;
        }
    }

    private void FixedUpdate()
    {
        bool wasGrounded = m_Grounded;
        m_Grounded = false;

        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        // This can be done using layers instead but Sample Assets will not overwrite your project settings.
        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                m_Grounded = true;
            }
        }
    }

}

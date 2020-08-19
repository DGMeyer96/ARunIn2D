using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGroundMove : MonoBehaviour
{

    public bool isPatrolling = true;
    public bool isFollowingPlayer = false;
    public bool canJump = false;
    public float speed = 100f;


    Transform[] patrolPoints;
    float distanceToPoint = 1;

    CreatePath path;
    int currentWaypoint = 1;

    Rigidbody2D rb;
    Animator animator;

    SpriteRenderer spriteRenderer;

    [SerializeField]
    private float jumpPower = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        path = GetComponent<CreatePath>();
    }


    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.x >= 0.1f || rb.velocity.x <= -0.1f)
        {
            //animations for movement
        }
        else
        {
            //animations for idle
        }

        if(rb.velocity.x >= 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if(rb.velocity.x <= -0.1f)
        {
            spriteRenderer.flipX = true;
        }

        if (path.GetPath().Count != 0)
        {
            FollowPath();
        }
    }


    void FollowPath()
    {
        if (path.GetPath().Count != 0)
        {
            if (currentWaypoint < path.GetPath().Count)
            {
                if (Vector2.Distance(transform.position, path.GetPath()[currentWaypoint]) >= 0.25f)
                {
                    Vector2 direction = (path.GetPath()[currentWaypoint] - (Vector2)transform.position).normalized;
                    Vector2 force = direction * speed * Time.deltaTime;

                    
                    rb.AddForce(force);
                }
                else if (Vector2.Distance(transform.position, path.GetPath()[currentWaypoint + 1]) <= 3f && path.GetPath()[currentWaypoint + 1].y - path.GetPath()[currentWaypoint].y == 1)
                {
                    Debug.Log("Jumping");
                    Vector2 direction = (path.GetPath()[currentWaypoint] - (Vector2)transform.position).normalized;
                    Vector2 force = direction * jumpPower;
                    rb.AddForce(Vector2.up * jumpPower);
                    currentWaypoint+=3;
                    Debug.Log(currentWaypoint);
                }
                else
                {
                    Debug.Log(currentWaypoint);
                    currentWaypoint++;
                }
            }
        }
    }
}

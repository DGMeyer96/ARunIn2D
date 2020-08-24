using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public enum EnemyType { ground, flight };

public class EnemyMovement : MonoBehaviour
{
    public EnemyType m_EnemyType;

    public Path aiPath;
    Seeker seeker;
    int currentWaypoint = 0;
    float nextWayPointDist = 0.5f;
    bool reachedEndOfPath = false;

    private Rigidbody2D m_rb;
    private Animator m_anim;

    [SerializeField] bool isGoingRight = false;

    [SerializeField] private Transform[] patrolPoints;
    [SerializeField] private float m_moveSpeed = 50f;

    [SerializeField] private int currentPatrolPoint = 0;

    [SerializeField] bool isMoving = true;
    float idleTimer = 10f;

    public bool isAttacking = false;
    float attackSpeed = 400f;

    public Transform target = null;
    


    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_anim = GetComponent<Animator>();
        seeker = GetComponent<Seeker>();
        GoingRight();

        if(seeker != null)
            seeker.StartPath(m_rb.position, patrolPoints[currentPatrolPoint].position, OnPathComplete);
    }

    // Update is called once per frame
    void Update()
    {
        GoingRight();
        if(isGoingRight && isMoving)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if(!isGoingRight && isMoving)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (isAttacking == false)
        {
            Patrol();
        }
        else
        {
            Attack();
        }
    }

    void GroundMove()
    {
        m_anim.SetBool("Moving", true);

        Vector2 direction = ((Vector2)patrolPoints[currentPatrolPoint].position - (Vector2)transform.position).normalized;
        Vector2 force = direction * m_moveSpeed * Time.deltaTime;
        if (Vector2.Distance(transform.position, patrolPoints[currentPatrolPoint].position) <= 0f)
            m_rb.AddForce(Vector2.zero);
        else
            m_rb.AddForce(force);
    }

    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            aiPath = p;
            currentWaypoint = 0;
        }
    }

    void FlightMove()
    {
        if (Vector2.Distance(transform.position, patrolPoints[currentPatrolPoint].position) <= .25f)
        {
            Debug.Log("Stopping");
            transform.localScale = new Vector3(1, -1, 1);
            m_rb.AddForce(Vector3.zero);
            //transform.localScale = new Vector3(1,-1,1);
            isMoving = false;
        }
        else
        {
            if(currentWaypoint >= aiPath.vectorPath.Count)
            {
                reachedEndOfPath = true;
                return;
            }
            else
            {
                reachedEndOfPath = false;
            }
            Vector2 direction = ((Vector2)aiPath.vectorPath[currentWaypoint] - m_rb.position).normalized;
            Vector2 force = direction * m_moveSpeed * Time.deltaTime;
            float dist = Vector2.Distance(m_rb.position, aiPath.vectorPath[currentWaypoint]);
            if(dist <= nextWayPointDist)
            {
                currentWaypoint++;
            }

            m_rb.AddForce(force);
        }
    }
    
    void Patrol()
    {
        if (m_EnemyType == EnemyType.ground && isMoving)
        {
            GroundMove();
            if (Vector2.Distance(transform.position, patrolPoints[currentPatrolPoint].position) <= 0.5f)
            {
                m_rb.AddForce(Vector2.zero);
                if (currentPatrolPoint == patrolPoints.Length - 1)
                {
                    currentPatrolPoint = 0;
                    isMoving = false;
                    m_anim.SetBool("Moving", false);
                }
                else
                {
                    currentPatrolPoint++;
                    isMoving = false;
                    m_anim.SetBool("Moving", false);
                }

            }
            if (isMoving == false)
            {
                idleTimer -= Time.deltaTime;
                if (idleTimer <= 0)
                {
                    idleTimer = 3f;
                    isMoving = true;
                }
                m_rb.AddForce(Vector2.zero);
            }
        }
        else if (m_EnemyType == EnemyType.flight && isMoving)
        {
            if (aiPath != null)
            {
                FlightMove();
            }
            else
                return;
        }

        
    }

    void Attack()
    {
        if (target != null)
        {
            Vector2 direction = ((Vector2)target.position - (Vector2)transform.position).normalized;
            Vector2 force = direction * attackSpeed * Time.deltaTime;
            m_rb.AddForce(force);
        }
        else
        {
            Debug.Log("No target");
        }
    }

    void GoingRight()
    {
        if (!isAttacking)
        {
            float direction = transform.position.x - patrolPoints[currentPatrolPoint].position.x;
            if (direction > 0)
            {
                isGoingRight = false;
            }
            else if (direction < 0)
            {
                isGoingRight = true;
            }
        }
        else
        {
            if (target != null)
            {
                float direction = transform.position.x - target.position.x;
                if (direction > 0)
                {
                    isGoingRight = false;
                }
                else if (direction < 0)
                {
                    isGoingRight = true;
                }
            }
        }
    }
}

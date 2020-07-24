using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.Tilemaps;

public class EnemyMove : MonoBehaviour
{
    Animator anim;
    public AIPath aiPath;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 1f || aiPath.desiredVelocity.x <= -1f)
        {
            
            anim.SetBool("IsMoving", true);
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }

        if (aiPath.desiredVelocity.x >= 0.1f)
        {
            transform.localScale = new Vector3(7f, 7f, 7f);
        }
        else if (aiPath.desiredVelocity.x <= -0.1f)
        {
            transform.localScale = new Vector3(-7f, 7f, 7f);
        }
    }
}

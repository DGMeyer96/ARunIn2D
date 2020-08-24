using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    private BoxCollider2D m_playerDetection;
    private EnemyMovement m_Move;

    // Start is called before the first frame update
    void Start()
    {
        m_playerDetection = GetComponent<BoxCollider2D>();
        m_Move = GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            m_Move.isAttacking = true;
            m_Move.target = collision.gameObject.transform;
        }
    }
}

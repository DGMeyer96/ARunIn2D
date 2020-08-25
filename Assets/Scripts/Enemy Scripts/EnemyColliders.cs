using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliders : MonoBehaviour
{
    
    public void recieveTriggerEnter(string fromObject, Collider2D other, int damage)
    {
        if(fromObject == "EnemyEyes")
        {
            Debug.Log("I see the player, he's a bitch");
            EnemyMovement eyes = gameObject.GetComponentInChildren<EnemyMovement>();
            eyes.target = other.gameObject.transform;
            eyes.isAttacking = true;
            return;
        }
        else if(fromObject == "EnemyDamage")
        {
            Debug.Log("Trying to cut a bitch");
            other.GetComponent<PlayerMovement>().TakeDamage(damage);
            return;
        }
    }
}

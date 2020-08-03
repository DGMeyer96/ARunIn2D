using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerBase : MonoBehaviour
{
    [SerializeField] int Health = 3;
    [SerializeField] int Damage = 1;

    Animator _Animur;

    private void Start()
    {
        _Animur = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if we touched a player
        if(collision.tag == "Player")
        {
            Debug.Log("Enemy damaged player!");
            //Problem is they can hit the player multiple times, need I-frames
            collision.GetComponent<PlayerMovement>().TakeDamage(Damage);
        }
    }

    public void TakeDamage(int damage)
    {
        //Take damage
        Health -= damage;
        Debug.Log("Enemy Health = " + Health);

        if(Health <= 0)
        {
            Death();
        }
        else
        {
            //Play hit animation
            _Animur.SetTrigger("Hit");
        }
    }

    void Death()
    {
        //Play death animationr 
        _Animur.SetBool("Death", true);
        //Disable EnemyAI Controller

        //0.5f is the length of the death animation
        Destroy(gameObject, 0.5f);
    }
}

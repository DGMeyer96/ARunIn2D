using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 1.0f;
    [SerializeField] private float _jumpHeight = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMovement();
    }

    void CharacterMovement()
    {
        if (Input.GetKeyDown("Horizontal"))
        {
            transform.Translate(new Vector2(1.0f, 0.0f) * _movementSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown("Jump"))
        {
            transform.Translate(new Vector2(0.0f, 1.0f) * _jumpHeight * Time.deltaTime);
        }
    }
}

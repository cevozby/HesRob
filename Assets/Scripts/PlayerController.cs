using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 3;

    Rigidbody2D playerRB;
    Animator playerAnim;
    SpriteRenderer playerSR;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerSR = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CharacterMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CharacterMovement()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.velocity = Vector2.right * speed;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.velocity = Vector2.left * speed;
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            playerRB.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            playerRB.velocity = Vector2.down * speed;
        }
        else
        {
            playerRB.velocity = Vector2.zero;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rbPlayer;

    public float moveSpeed;
    public float jumpForcePlayer;

    [Header("State Check")]
    public bool canJump;


    
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();

    }
    
    void Update()
    {
        checkInput();

    }

    void FixedUpdate()
    {
        Movement();
        Jump();
    }
    
    void checkInput()
    {
        if(Input.GetButtonDown("Jump"))
        {
            canJump = true;
        }
   
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        rbPlayer.velocity = new Vector2(horizontalInput * moveSpeed, rbPlayer.velocity.y);

    }
    
    void Jump()
    {
        if(canJump)
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForcePlayer);
            canJump = false;
        }


    }
}

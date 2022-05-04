using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rbPlayer;

    public float moveSpeed;

    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Movement();
    }

    void LateUpdate()
    {
        
    }

    void Movement()
    {
        float horozontalInput = Input.GetAxisRaw("Horizontal");

        rbPlayer.velocity = new Vector2(horozontalInput * moveSpeed, rbPlayer.velocity.y);


    }
}

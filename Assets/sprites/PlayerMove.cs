using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private int playerSpeed = 10;
    private bool facingRight = false;
    private int playerJumpPower = 1200;
    private float moveX;
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    void Move() 
    {
        //controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        //directions
        if (moveX < 0.0f && !facingRight)
        {
            FlipPlayer();
        }
        else if(moveX > 0.0f && facingRight)
        {
            FlipPlayer();
        }
        //physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}

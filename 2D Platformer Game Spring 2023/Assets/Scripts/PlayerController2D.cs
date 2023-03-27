using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    //Player Stats
    [Header("Player Stats")]
    public float speed; //How fast the player is going to move
    public float jumpForce; //How high the player will jump
    private float moveInput; //Get move input value
 
    //Player Rigidbody
    [Header("Rigidbody Component")]
    private Rigidbody2D rb;
    public bool isFacingRight = true;

    //Player Jump
    [Header("Player Jump Settings")]
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public bool doubleJump;

    // Start is called before the first frame update
    void Start()
    {
        //Get Rigidbody Component Reference
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); //Define what is ground and check for ground

        moveInput = Input.GetAxis("Horizontal"); //Get the Horizontal Keybinding which will return a value between -1 and 1
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); //Move the player left and right

        //If the player is moving right but facing left slip the player right
        if(!isFacingRight && moveInput > 0) 
        {
            FlipPlayer();
        }
        //If the player is moving left but facing right flip the player left
        else if(isFacingRight && moveInput < 0)
        {
            FlipPlayer();
        }
    }
    
    //Update is called once per frame. We will use Update for the jump as we will need every grame. Fixed update
    void Update()
    {
        if(isGrounded)
        {
            doubleJump = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce; //Makes the player jump
            doubleJump = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce; //Apply jumpForce to player making the player jump
        }
    }

    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale; //Local variable that stores localscale value
        scaler.x *= -1; //Flip the sprite graphic
        transform.localScale = scaler; 
    }
}
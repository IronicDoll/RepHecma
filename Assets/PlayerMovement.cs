using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{

    public CoolCharacterController controller;
    public GameObject groundCheck;
    public float runSpeed = 40F;
    private bool canJump = false;
    private float jumpForce = 400f;

    float horizontalMove = 0F;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {

            jump = true;
        }
    }


    void FixedUpdate ()
    {

        //Move our character
        if (jump && canJump)
           Jump();
        
    }

    private void Jump()
    {
       GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
      jump = false;
   }

    void OnCollisionEnter2D(Collision2D col)
    {
       if (col.gameObject.GetComponent<TilemapCollider2D>() != null)
       {
          canJump = true;
       }
    }
}

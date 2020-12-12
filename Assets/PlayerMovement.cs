using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{

   public CoolCharacterController controller;
   public float runSpeed = 40F;
   internal bool canJump = false;
   private float jumpForce = 800f;
   public BoxCollider2D head;

   float horizontalMove = 0F;
   bool jump = false;
    bool crouch= false;

   // Update is called once per frame
   void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(canJump && Input.GetButtonDown("Jump"))
           Jump();

        if (Input.GetAxisRaw("Vertical") < 0)
        {
           head.enabled = false;
        }
        else
        {
           head.enabled = true;
        }
    }
   
    private void Jump()
    {
       GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
       canJump = false;
    }


   void FixedUpdate ()
    {
       //Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
    }


}
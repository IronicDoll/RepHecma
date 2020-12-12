using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CoolCharacterController controller;

    public float runSpeed = 40F;

    float horizontalMove = 0F;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
    }


    void FixedUpdate ()
    {

        //Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}

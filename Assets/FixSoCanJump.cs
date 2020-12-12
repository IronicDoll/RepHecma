using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FixSoCanJump : MonoBehaviour
{
   public PlayerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       if (col.gameObject.GetComponent<TilemapCollider2D>() != null)
       {
          PlayerMovement.canJump = true;
       }
    }

}

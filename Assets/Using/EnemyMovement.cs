using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   int direction = 1;
   int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       Vector3 movement = new Vector3(direction, 0, 0f);
       transform.position += movement.normalized * Time.fixedDeltaTime * speed;
   }
}

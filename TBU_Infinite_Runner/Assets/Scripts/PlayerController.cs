using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody myBody;
    public float maxSpeed;
    public float moveAcceleration;
    public float jumpAcceleration;
    private bool isGrounded = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        isGrounded = false;
    }


    void FixedUpdate ()
    {
        ConstantMove();
    }
    //this function moves the ball on the Z axis
    void ConstantMove()
    {
        Vector3 newVelocity = myBody.velocity;
        //don't move with higher speed than maxSpeed
        if (myBody.velocity.z >= maxSpeed)
        {
            newVelocity.z = maxSpeed;
        }
        //accelerate to max speed
        else
        {
            newVelocity.z = newVelocity.z + moveAcceleration;

        }
        myBody.velocity = newVelocity;
    }
    void Jump()
    {
        Vector3 jumpVelocity = myBody.velocity;
        jumpVelocity.y += jumpVelocity.y + jumpAcceleration;
        myBody.velocity = jumpVelocity;
    }   
}

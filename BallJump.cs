using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    Rigidbody rb;
    public float jumpSpeed;

    void Start()
    {
        jumpSpeed = 10f;
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Ground")
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
    }
}

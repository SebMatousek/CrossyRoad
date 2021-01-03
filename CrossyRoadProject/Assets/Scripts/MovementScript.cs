using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody rb;
    public bool isGrounded;

    [Range(1, 10)] public float jumpVelocity;
    [Range(1, 10)] public float playerVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = new Vector3(playerVelocity, jumpVelocity, 0);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                rb.velocity = new Vector3(0, jumpVelocity, playerVelocity);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                rb.velocity = new Vector3(0, jumpVelocity, -playerVelocity);
            }
        }
    }

    private void OnCollisionStay()
    {
        isGrounded = true;

    }

    private void OnCollisionExit()
    {
        isGrounded = false;
    }
}

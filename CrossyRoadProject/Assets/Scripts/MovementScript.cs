using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public bool isGrounded;

    [Range(1, 10)]
    public float jumpVelocity;
    [Range(1, 10)]
    public float playerVelocity;

    private void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, jumpVelocity, playerVelocity);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                GetComponent<Rigidbody>().velocity = new Vector3(-playerVelocity, jumpVelocity, 0);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                GetComponent<Rigidbody>().velocity = new Vector3(playerVelocity, jumpVelocity, 0);
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

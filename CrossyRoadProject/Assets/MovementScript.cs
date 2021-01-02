using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] public Rigidbody rb;

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

    void OnCollisionStay()
    {
        isGrounded = true;

    }

    void OnCollisionExit()
    {
        isGrounded = false;
    }
}

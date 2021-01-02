using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 0.25f;
    [SerializeField] public Rigidbody rb;
    [SerializeField] public float jumpForce = 2.1f;

    public Vector3 jump;
    public bool isGrounded;

    void Start()
    {
        jump = new Vector3(0.0f, jumpForce, speed);
    }


    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(jump, ForceMode.Impulse);
            isGrounded = false;
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

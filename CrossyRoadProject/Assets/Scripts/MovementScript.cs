using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private float speed = 0.25f;
    private Rigidbody rb;
    [SerializeField] public float jumpForce = 2.1f;

    public Vector3 jump;
    public bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(speed, jumpForce, 0);
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            rb.AddForce(jump, ForceMode.Impulse);
            isGrounded = false;
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

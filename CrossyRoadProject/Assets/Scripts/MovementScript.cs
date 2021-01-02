using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
<<<<<<< HEAD:CrossyRoadProject/Assets/MovementScript.cs
    [SerializeField] public Rigidbody rb;
=======
    [SerializeField] private float speed = 0.25f;
    private Rigidbody rb;
    [SerializeField] public float jumpForce = 2.1f;
>>>>>>> 2d3413bbfae45167a5063e7ddbcfb6118c95a938:CrossyRoadProject/Assets/Scripts/MovementScript.cs

    public bool isGrounded;

<<<<<<< HEAD:CrossyRoadProject/Assets/MovementScript.cs
    [Range(1, 10)]
    public float jumpVelocity;
    [Range(1, 10)]
    public float playerVelocity;
=======
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(speed, jumpForce, 0);
    }

>>>>>>> 2d3413bbfae45167a5063e7ddbcfb6118c95a938:CrossyRoadProject/Assets/Scripts/MovementScript.cs

    private void Update()
    {
<<<<<<< HEAD:CrossyRoadProject/Assets/MovementScript.cs
        if (isGrounded)
=======
        if (Input.GetKey(KeyCode.W) && isGrounded)
>>>>>>> 2d3413bbfae45167a5063e7ddbcfb6118c95a938:CrossyRoadProject/Assets/Scripts/MovementScript.cs
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

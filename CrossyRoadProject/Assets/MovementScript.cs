using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
<<<<<<< HEAD:CrossyRoadProject/Assets/Scripts/MovementScript.cs
    public bool isGrounded;

    [Range(1, 10)]
    public float jumpVelocity;
    [Range(1, 10)]
    public float playerVelocity;
=======
    [SerializeField] private float speed = 0.25f;
    [SerializeField] public Rigidbody rb;
    [SerializeField] public float jumpForce = 2.1f;

    public Vector3 jump;
    public bool isGrounded;

    void Start()
    {
        jump = new Vector3(0.0f, jumpForce, speed);
    }

>>>>>>> parent of 2d3413b... Row generation + camera following only on X axis:CrossyRoadProject/Assets/MovementScript.cs

    private void Update()
    {
<<<<<<< HEAD:CrossyRoadProject/Assets/Scripts/MovementScript.cs
        if (isGrounded)
=======
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
>>>>>>> parent of 2d3413b... Row generation + camera following only on X axis:CrossyRoadProject/Assets/MovementScript.cs
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

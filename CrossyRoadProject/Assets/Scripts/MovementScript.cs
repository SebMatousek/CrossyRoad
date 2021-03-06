﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody rb;
    public bool isGrounded;

    [Range(0, 10)] public float jumpVelocity;
    [Range(0, 10)] public float playerVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                var Object = GameObject.FindGameObjectsWithTag("Object");

                for (int i = 0; i < Object.Length; i++)
                {
                    if (Object[i].transform.position.x - 1.2f < GameObject.Find("Chicken").transform.position.x && Object[i].transform.position.x > GameObject.Find("Chicken").transform.position.x && (Object[i].transform.position.z - 0.55f < GameObject.Find("Chicken").transform.position.z && Object[i].transform.position.z + 0.55f > GameObject.Find("Chicken").transform.position.z))
                    {
                        //Debug.Log(Object[i]);
                        return;
                    }
                }

                rb.velocity = new Vector3(playerVelocity, jumpVelocity, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {


                rb.velocity = new Vector3(0, jumpVelocity, playerVelocity);
                Quaternion target = Quaternion.Euler(0, -200, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 60.0f);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector3(0, jumpVelocity, -playerVelocity);
                Quaternion target = Quaternion.Euler(0, 0, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 60.0f);
            }
            else
            {
                Quaternion target = Quaternion.Euler(0, -90, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 20.0f);
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

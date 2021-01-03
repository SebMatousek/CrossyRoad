using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJumpScript : MonoBehaviour
{
    public float fallMultiplier = 2.5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * (Physics.gravity.y * (fallMultiplier - 1.2f) * Time.deltaTime);
        }
    }
}

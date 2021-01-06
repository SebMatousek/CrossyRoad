using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMovementScript : MonoBehaviour
{
    [Range(0, 100)]
    public int objectSpeed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, -objectSpeed);
    }
}

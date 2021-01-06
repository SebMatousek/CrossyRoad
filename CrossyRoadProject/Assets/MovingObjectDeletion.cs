using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectDeletion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var Object = GameObject.FindGameObjectsWithTag("MovingObject");

        for (int i = 0; i < Object.Length; i++)
        {
            if (Object[i].transform.position.z < GameObject.Find("Chicken").transform.position.z - 10)
            {
                Destroy(Object[i]);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObjectScript : MonoBehaviour
{
    [SerializeField] private Transform objectToFollow;

    private void Update()
    {
        transform.position = new Vector3(objectToFollow.position.x, 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotation : MonoBehaviour
{
    public Transform target; // Reference to the object whose rotation will be copied

    void Update()
    {
        if (target != null)
        {
            // Copy the rotation of the target object
            transform.rotation = target.rotation;
        }
        else
        {
            Debug.LogWarning("Target object is not assigned!");
        }
    }
}

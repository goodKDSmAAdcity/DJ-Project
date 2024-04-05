using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed of the object
    public float stopDistance = 1f; // Distance threshold to stop following the mouse

    private bool isFollowing = true; // Flag to control if the object should follow the mouse

    void Update()
    {
        if (isFollowing)
        {
            // Get the position of the mouse in world coordinates
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Ensure the object stays on the same z-axis as the camera

            // Calculate the direction towards the mouse position
            Vector3 direction = mousePosition - transform.position;

            // Calculate the distance between the object and the mouse cursor
            float distanceToMouse = direction.magnitude;

            // Check if the distance is greater than the stop distance
            if (distanceToMouse > stopDistance)
            {
                // Normalize the direction vector to ensure consistent movement speed
                direction.Normalize();

                // Move the object towards the mouse position
                transform.position += direction * moveSpeed * Time.deltaTime;
            }
            else
            {
                // Object is within the stop distance, stop following
                isFollowing = false;
            }
        }
        else
        {
            // Check if the distance between the object and the mouse cursor is greater than stopDistance
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;
            float distanceToMouse = Vector3.Distance(transform.position, mousePosition);
            if (distanceToMouse > stopDistance)
            {
                // Re-enable following the mouse
                isFollowing = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float movementSpeed = 5f; // Adjust the speed of movement
    public float rotationSpeed = 360f; // Adjust the speed of rotation
    public float movementDelay = 0.1f; // Adjust the delay for movement
    public float stopDistance = 2f; // The distance threshold for stopping movement

    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = transform.position;
    }

    private void Update()
    {
        // Update the target position after a delay
        StartCoroutine(UpdateTargetPosition());

        // Check the distance to the target position
        float distanceToTarget = Vector3.Distance(transform.position, targetPosition);

        // Move towards the target position only if within the stop distance
        if (distanceToTarget > stopDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
        }

        // Rotate towards the mouse cursor
        RotateTowardsMouseCursor();
    }

    private IEnumerator UpdateTargetPosition()
    {
        yield return new WaitForSeconds(movementDelay);
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition = new Vector3(cursorPos.x, cursorPos.y, transform.position.z);
    }

    private void RotateTowardsMouseCursor()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f; // Adjust the distance from the camera
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x -= objectPos.x;
        mousePos.y -= objectPos.y;
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}

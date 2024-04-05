using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed = 5f; // Speed at which the object moves along the x-axis

    private void Update()
    {
        // Calculate the movement amount based on speed and deltaTime
        float movementAmount = speed * Time.deltaTime;

        // Move the object along the x-axis
        transform.Translate(Vector3.right * movementAmount);
    }
}

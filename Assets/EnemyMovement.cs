using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float minY = -4f;
    public float maxY = 4f;
    public float moveDuration = 2f;  // How long it takes to move to the new position

    void Start()
    {
        StartCoroutine(MoveToRandomYPosition());
    }

    IEnumerator MoveToRandomYPosition()
    {
        while (true)
        {
            // Get current y position and determine a random target y position
            float startY = transform.position.y;
            float targetY = Random.Range(minY, maxY);

            // Lerp from startY to targetY over moveDuration seconds
            float elapsed = 0f;
            while (elapsed < moveDuration)
            {
                elapsed += Time.deltaTime;
                float newY = Mathf.Lerp(startY, targetY, elapsed / moveDuration);
                Vector3 pos = transform.position;
                pos.y = newY;
                transform.position = pos;
                yield return null;
            }

            // Ensure we reach the target exactly
            Vector3 finalPos = transform.position;
            finalPos.y = targetY;
            transform.position = finalPos;

            // Optionally, wait before moving to the next random position (if needed)
            // yield return new WaitForSeconds(someWaitTime);
        }
    }
}

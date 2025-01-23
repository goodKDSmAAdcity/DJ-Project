using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        // Rotate direction 90 degrees to the right
        Vector2 rotatedDirection = new Vector2(-direction.y, direction.x);

        transform.up = rotatedDirection; // Apply the rotated direction
    }
}
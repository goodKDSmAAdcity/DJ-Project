using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer1 : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;
    public Transform firePoint;
    public GameObject bulletPrefab;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            movement.y = 1;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            movement.y = -1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

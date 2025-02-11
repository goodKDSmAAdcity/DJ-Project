using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer2 : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource source;
    public AudioClip clip;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movement.y = 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movement.y = -1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Shoot();
        }
        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)){
            movement.y = 0;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    void Shoot()
    {
        source.Play();
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

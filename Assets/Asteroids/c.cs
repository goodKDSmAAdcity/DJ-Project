using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool MissionComplete=false;
    void Update()
    {
        rb.AddForce(new Vector2(-14f,0) * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Detect if the player enters
        {
            Debug.Log("Player reached Finish Line");
            MissionComplete= true;
        }
    }
}

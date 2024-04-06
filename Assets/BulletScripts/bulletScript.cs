using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 20;
    public GameObject impactEffect;

    private void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2f);
    }
}

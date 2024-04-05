using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    public Rigidbody2D rb;

    void Update()
    {
        rb.AddForce(new Vector2(-10f,0) * Time.deltaTime);
    }
}

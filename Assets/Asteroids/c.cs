using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool MissionComplete=false;
    void Update()
    {
        rb.AddForce(new Vector2(-20f,0) * Time.deltaTime);
    }
}

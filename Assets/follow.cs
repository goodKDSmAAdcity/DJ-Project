using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private void Update()
    {
        if(player != null)
        {
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            transform.position += direction*moveSpeed*Time.deltaTime;
        }
    }
}

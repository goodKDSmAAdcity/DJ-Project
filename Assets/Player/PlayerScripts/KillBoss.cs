using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBoss : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject deathEffect;

    private void Start()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision is with the hitbox
        if (collision.CompareTag("Player"))
        {
            Debug.Log("ishit");
            GameObject death = Instantiate(deathEffect, objectToDestroy.transform.position, transform.rotation);
            Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
            Destroy(objectToDestroy);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBoss : MonoBehaviour
{
    public GameObject objectToDestroy;
    public GameObject deathEffect;
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the hitbox
        if (collision.gameObject.CompareTag("KillBoss"))
        {
            Debug.Log("ishit");
            GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
            Destroy(objectToDestroy);
        }
    }
}

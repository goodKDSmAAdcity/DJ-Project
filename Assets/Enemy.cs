using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health-=damage;
        if(health <=0)
        {
            Die();
        }
    }
    void Die()
    {
        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Destroy(gameObject);
    }
}

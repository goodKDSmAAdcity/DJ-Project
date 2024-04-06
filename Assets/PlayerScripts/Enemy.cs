using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public HP healthBar;
    public GameObject deathEffect;
     void Start()
    {
        healthBar.SetMaxHealth(health);
    }

    public void TakeDamage(int damage)
    {
        health-=damage;
        healthBar.setHealth(health);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;

    public GameObject deathEffect;
    public HP healthBar;

    private void Start()
    {

        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        healthBar.SetHealth(currenthealth);
        Debug.Log(currenthealth);
        if (currenthealth <= 0)
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


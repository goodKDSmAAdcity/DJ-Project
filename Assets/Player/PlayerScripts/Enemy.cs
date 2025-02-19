using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Enemy : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public GameObject deathEffect;
    public event Action OnDestroyed;
    private int chance;
    public GameObject HealthPickup;
    private void Start()
    {
        
        currenthealth = maxhealth;
        chance = Random.Range(1,10);
    }

    public void TakeDamage(int damage)
    {
        currenthealth-=damage;
        Debug.Log(currenthealth);
        if(currenthealth <=0)
        {
            Die();
        }
    }
    void Die()
    {
        if (chance>=9)
        {
            Instantiate(HealthPickup, transform.position, new Quaternion(0,0,0,0));
        }
        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Destroy(gameObject);
        OnDestroyed();

    }
}

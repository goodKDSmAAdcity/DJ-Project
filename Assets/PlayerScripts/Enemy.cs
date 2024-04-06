using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public GameObject deathEffect;
    public event Action OnDestroyed;


    private void Start()
    {
        
        currenthealth = maxhealth;
       
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
        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        if(OnDestroyed!=null)
        {
            OnDestroyed.Invoke();
        }
        Destroy(gameObject);
    }
}

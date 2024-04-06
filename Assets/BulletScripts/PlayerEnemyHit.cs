using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyHit : MonoBehaviour
{
    public int damage = 20;
    public GameObject impactEffect;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        GameObject impact = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(impact, impact.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Destroy(gameObject);
    }

}

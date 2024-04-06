using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 20;
    public GameObject impactEffect;

    private void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        BossHP boss = collision.GetComponent<BossHP>();
        if (boss != null)
        {
            boss.TakeDamage(damage);    
        }
        GameObject impact = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(impact, impact.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Destroy(gameObject);
    }
}

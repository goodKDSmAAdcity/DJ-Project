using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerHit : MonoBehaviour
{
    public GameObject impactEffect;
    public int damage = 20;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Player player= collision.GetComponent<Player>();
        if(player != null)
        {
            player.TakeDamage(damage);
        }

        GameObject impact = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(impact, impact.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Destroy(gameObject);
    }
}

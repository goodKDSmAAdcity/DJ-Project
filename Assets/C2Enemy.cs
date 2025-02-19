using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class C2Enemy : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;
    public GameObject deathEffect;
    public event Action OnDestroyed;
    private int chance;
    public GameObject HealthPickup;
    public float deathMovementSpeed = 5f; // Speed at which the enemy moves after death
    private bool isDead = false; // Flag to track if the enemy has "died"
    private Transform playerTransform;

    private void Start()
    {
        currenthealth = maxhealth;
        chance = Random.Range(1, 10);
        playerTransform = FindObjectOfType<Player>().transform; // Find the player automatically
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        Debug.Log(currenthealth);
        if (currenthealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (isDead)
            return; // Prevent multiple deaths if already "dead"

        isDead = true;

        // 10% chance to spawn a health pickup
        if (chance >= 9)
        {
            Instantiate(HealthPickup, transform.position, Quaternion.identity);
        }

        // Instantiate the death effect
        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);

        // Continue moving the enemy after death
        StartCoroutine(MoveAfterDeath());
    }

    private IEnumerator MoveAfterDeath()
    {
        while (true)
        {
            // Move the enemy to the left (-x axis)
            transform.Translate(Vector3.left * deathMovementSpeed * Time.deltaTime);

            // If the enemy reaches the player's position, destroy it
            if (playerTransform != null && Vector3.Distance(transform.position, playerTransform.position) < 1f)
            {
                Debug.Log("Enemy reached the player and is destroyed.");
                Destroy(gameObject);
                OnDestroyed?.Invoke();
                yield break; // Stop the coroutine
            }

            // Wait for the next frame
            yield return null;
        }
    }
}

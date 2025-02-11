using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AsteroidCollision : MonoBehaviour
{
    public float restartDelay = 1f; // Delay before restarting the level
    public GameObject deathEffect;
    public int sceneIndex; // Optional: Set this if you want to load a specific scene
    public GameObject sprite;
    public Rigidbody2D rb;
    public Follow followscript;
    public Weapon Weaponscript;
    public Player health;
    public HP HealthBar;
    public AudioSource source;
    public AudioClip clip;

    public bool isDead=false;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid") && isDead == false)
        {
            isDead = true;
            health.currenthealth= 0;
            HealthBar.SetHealth(0);
            DestroyShip();
        }
    }

    public void DestroyShip()
    {
        // Create a death effect at the player's position
        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        source.Play();
        // Destroy the death effect after its animation finishes
        Destroy(death, 1f); // Adjust time if the animation length is different

        // Destroy the player game object
        Destroy(sprite);
        Destroy(rb);
        // Restart the level after a delay
        Invoke("RestartLevel", restartDelay);
    }

    public void RestartLevel()
    {
        // Get the current scene index
        // Reload the current scene
        Destroy(gameObject);
        SceneManager.LoadScene(9);
    }
}
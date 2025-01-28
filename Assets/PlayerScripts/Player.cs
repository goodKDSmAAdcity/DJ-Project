using System;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;

    public GameObject deathEffect;
    public HP healthBar;
    public event Action OnDestroyed;
    public MovementPlayer1 ondeath;
    public int sceneIndex;
    public bool ifMultiplayer;
    private Vector3 initialPos;
    private Quaternion initialRot;
    public TMP_Text Score;
    private int deathCount;
<<<<<<< Updated upstream:Assets/PlayerScripts/Player.cs
   
    
    
=======
    public bool HP;
    private static Player instance; // Singleton instance.
>>>>>>> Stashed changes:Assets/Player/PlayerScripts/Player.cs

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    private void Awake()
    {
        // Singleton pattern: Ensures only one instance of the player exists across scenes.
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Destroy any duplicate instances.
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persist this instance across scenes.
        }
    }

    private void Start()
    {
<<<<<<< Updated upstream:Assets/PlayerScripts/Player.cs

        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
        initialPos= transform.position;
=======
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        currenthealth = maxhealth;

        if (HP)
        {
            healthBar.SetMaxHealth(maxhealth);
        }

        initialPos = transform.position;
>>>>>>> Stashed changes:Assets/Player/PlayerScripts/Player.cs
        initialRot = transform.rotation;
        deathCount = 0;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        Debug.Log("ishit");
<<<<<<< Updated upstream:Assets/PlayerScripts/Player.cs
        healthBar.SetHealth(currenthealth);
=======

        if (HP)
        {
            healthBar.SetHealth(currenthealth);
        }

>>>>>>> Stashed changes:Assets/Player/PlayerScripts/Player.cs
        Debug.Log(currenthealth);
        if (currenthealth <= 0)
        {
            if (ifMultiplayer)
            {
                deathCount += 1;
                Debug.Log(deathCount);
                Score.text = deathCount.ToString();
            }
            Die();
        }
    }

    void Die()
    {
        // Instantiate death effect.
        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);

        if (OnDestroyed != null)
        {
            OnDestroyed.Invoke();
        }

        // Disable player components for death.
        spriteRenderer.enabled = false; // Hide the sprite.
        rb.simulated = false;          // Disable Rigidbody2D.

        if (ifMultiplayer)
        {
            Respawn(); // Respawn immediately for multiplayer mode.
        }
        else
        {
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
            StartCoroutine(RespawnAfterSceneLoad());
        }
    }

    IEnumerator RespawnAfterSceneLoad()
    {
        yield return new WaitForSeconds(0.1f); // Small delay to ensure the scene has loaded.
        Respawn();
    }

    void Respawn()
    {
        // Reset player position, rotation, and health.
        transform.position = initialPos;
        transform.rotation = initialRot;
        currenthealth = maxhealth;
<<<<<<< Updated upstream:Assets/PlayerScripts/Player.cs
=======

        if (HP)
        {
            healthBar.SetMaxHealth(maxhealth);
        }

        // Re-enable player components.
        spriteRenderer.enabled = true; // Show the sprite.
        rb.simulated = true;          // Re-enable Rigidbody2D.
>>>>>>> Stashed changes:Assets/Player/PlayerScripts/Player.cs
    }
}

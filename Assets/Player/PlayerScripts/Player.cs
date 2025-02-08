using System;
using System.Collections;
using System.Collections.Generic;
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
    public int sceneIndex;
    public GameObject prefab;
    private Vector3 initialPos;
    private Quaternion initialRot;
    public TMP_Text Score;
    private int deathCount; 
    public bool isDead;
    
    public AsteroidCollision asteroidCollision;


    private void Start()
    {
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
        initialPos= transform.position;
        initialRot = transform.rotation;
        deathCount= 0;
        isDead= false;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        Debug.Log("ishit");
            healthBar.SetHealth(currenthealth);
        Debug.Log(currenthealth);
        if (currenthealth <= 0 && isDead == false)
        {
            if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
                Destroy(death, 1f);
                deathCount += 1;
                Debug.Log(deathCount);
                Score.text = deathCount.ToString();
                currenthealth = 100;
                healthBar.SetHealth(currenthealth);
                transform.position = new Vector3(initialPos.x, 0,0);
                
            }
            else
            {
                isDead = true;
                asteroidCollision.DestroyShip();
            }
        }
    }
}


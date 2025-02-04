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
    public MovementPlayer1 ondeath;
    public int sceneIndex;
    public bool ifMultiplayer;
    public GameObject prefab;
    private Vector3 initialPos;
    private Quaternion initialRot;
    public TMP_Text Score;
    private int deathCount;
    private bool isDead;
    
    public AsteroidCollision asteroidCollision;
    public int nameID;


    private void Start()
    {
        nameID=UnityEngine.Random.Range(1, 100);
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
            if(ifMultiplayer == true)
            {
                deathCount+=1;
                Debug.Log(deathCount);
                Score.text = deathCount.ToString();
            }
            isDead= true;
            asteroidCollision.DestroyShip();
        }
    }
}


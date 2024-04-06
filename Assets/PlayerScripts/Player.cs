using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public int maxhealth = 100;
    public int currenthealth;

    public GameObject deathEffect;
    public HP healthBar;
    public event Action OnDestroyed;
    public MovementPlayer1 ondeath;
    public bool ifMultiplayer;
    public GameObject prefab;
    private Vector3 initialPos;
    private Quaternion initialRot;
    public TMP_Text Score;
    private int deathCount;


    private void Start()
    {

        currenthealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
        initialPos= transform.position;
        initialRot = transform.rotation;
        deathCount= 0;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        healthBar.SetHealth(currenthealth);
        Debug.Log(currenthealth);
        if (currenthealth <= 0)
        {
            if(ifMultiplayer == true)
            {
                deathCount+=1;
                Debug.Log(deathCount);
                Score.text = deathCount.ToString();
            }
            Die();
        }
    }
    void Die()
    {
        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        if(OnDestroyed!= null)
        {
            OnDestroyed.Invoke(); 
        }
        if (ifMultiplayer)
        {
            Respawn();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Respawn()
    {
        transform.position = initialPos;
        transform.rotation = initialRot;
        currenthealth = maxhealth;
    }
}


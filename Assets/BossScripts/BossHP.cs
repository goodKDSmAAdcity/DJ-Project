using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHP : MonoBehaviour
{
    public int maxhealth = 1000;
    public int currenthealth;

    public GameObject deathEffect;
    public HP healthBar;


    private void Start()
    {
        
        currenthealth = maxhealth;
        healthBar.SetMaxHealth(currenthealth);  
       
    }

    public void TakeDamage(int damage)
    {
        currenthealth-=damage;
        healthBar.SetHealth(currenthealth);
        if(currenthealth <=0)
        {
            Die();
        }
    }
    void Die()
    {
        SceneManager.LoadScene("Boss Fight Race");
    }
}

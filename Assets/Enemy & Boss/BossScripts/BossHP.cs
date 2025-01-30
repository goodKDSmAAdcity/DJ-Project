using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHP : MonoBehaviour
{
    public int maxhealth = 1000;
    public int currenthealth;
    public bool IfHealthBar;
    public GameObject deathEffect;
    public HP healthBar;


    private void Start()
    {
        
        currenthealth = maxhealth;
        if (IfHealthBar)
        {
            healthBar.SetMaxHealth(currenthealth);
        }
       
    }

    public void TakeDamage(int damage)
    {
        currenthealth-=damage;
        if (IfHealthBar)
        {
            healthBar.SetHealth(currenthealth);
        }
        if(currenthealth <=0)
        {
            Die();
        }
    }
    void Die()
    {
        SceneManager.LoadScene(7);
    }
}

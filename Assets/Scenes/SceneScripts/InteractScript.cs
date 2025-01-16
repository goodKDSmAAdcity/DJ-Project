using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractScript : MonoBehaviour
{
    public GameObject boss;
    public GameObject deathEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish1")) {
            SceneManager.LoadScene("CombatLvl1");
        }
        if (collision.gameObject.CompareTag("Finish2"))
        {
            SceneManager.LoadScene("CombatLvl2");
        }
        if (collision.gameObject.CompareTag("FinalBossLine"))
        {
            SceneManager.LoadScene("ending"); 
        }
        if (collision.gameObject.CompareTag("KillBoss"))
        {
            GameObject death = Instantiate(deathEffect, boss.transform.position, boss.transform.rotation);
            Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
            Destroy(boss);
        }
    }
}

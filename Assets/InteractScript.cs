using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractScript : MonoBehaviour
{
    public GameObject boss;
    public GameObject deathEffect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("MainLobby");
        }
        if (collision.gameObject.CompareTag("Race"))
        {
            SceneManager.LoadScene("Race1");
        }
        if (collision.gameObject.CompareTag("Battle"))
        {
            SceneManager.LoadScene("CombatLvl1");
        }
        if (collision.gameObject.CompareTag("FinalBoss"))
        {
            SceneManager.LoadScene("BOSSFIGHT");
        }
        if (collision.gameObject.CompareTag("Shop")){
            SceneManager.LoadScene("Vendor");
        }
        if (collision.gameObject.CompareTag("FinalBossLine"))
        {
            SceneManager.LoadScene("MainLobby"); 
        }
        if (collision.gameObject.CompareTag("KillBoss"))
        {
            GameObject death = Instantiate(deathEffect, boss.transform.position, boss.transform.rotation);
            Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
            Destroy(boss);
        }
    }
}

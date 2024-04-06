using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractScript : MonoBehaviour
{
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
    }
}

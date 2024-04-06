using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AsteroidCollision : MonoBehaviour
{
   public float restartDelay = 0f;
    public GameObject deathEffect;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            DestroyShip();
        }
    }

    public void DestroyShip()
    {

        GameObject death = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(death, death.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
        Destroy(gameObject);
        Invoke("ResetScene", 2f);

        //Invoke("RestartLevel", restartDelay);
    }
    void ResetScene()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void RestartLevel()
   {
        // Get the current scene index
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the current scene again after a delay
        //SceneManager.LoadScene(currentSceneIndex);
        //Application.LoadLevel (Application.loadedLevel);


  }
}
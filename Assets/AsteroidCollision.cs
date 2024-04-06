using UnityEngine;
using UnityEngine.SceneManagement; 

public class AsteroidCollision : MonoBehaviour
{
   public float restartDelay = 0f; 

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            DestroyShip();
        }
    }

    public void DestroyShip()
    {
        Destroy(gameObject);
       Application.LoadLevel (Application.loadedLevel);

        //Invoke("RestartLevel", restartDelay);
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
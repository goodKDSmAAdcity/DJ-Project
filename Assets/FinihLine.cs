using UnityEngine;
using UnityEngine.SceneManagement;

public class FinihLine : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("OpenQ");
        }
        if (collision.gameObject.CompareTag("Commander"))
        {
            SceneManager.LoadScene("race 2");
        }
        if (collision.gameObject.CompareTag("Commander1"))
        {
            SceneManager.LoadScene("race 3");
        }
    }
}

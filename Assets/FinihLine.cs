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
    }
}

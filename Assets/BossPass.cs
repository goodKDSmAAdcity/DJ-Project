using UnityEngine;
using UnityEngine.SceneManagement;

public class BossPass : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BossEnd"))
        {
            SceneManager.LoadScene("");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionSelect : MonoBehaviour
{
    public GameObject UI;
    public void Back()
    {
        SceneManager.LoadScene("MainLobby");
    }

    public void Proceed()
    {
            
    }


}

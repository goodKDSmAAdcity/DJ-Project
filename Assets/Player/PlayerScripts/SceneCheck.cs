using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCheck : MonoBehaviour
{
    
    public int sceneIndex;// Start is called before the first frame update
    public bool combatScene=false;
    public bool raceScene=false;
    public bool lobbyScene=false;
    public bool multiplayer = false;
    
    public GameObject Player;
    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex == 7)
        {
            Player.transform.position = new Vector3(0f, 0f, 0f);
        }
    }
    void Update()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex == 2 || sceneIndex == 4 || sceneIndex == 7 || sceneIndex == 12)
        {
            raceScene = true;
            lobbyScene = false;
            combatScene = false;
            multiplayer = false;
        }
        if (sceneIndex == 3 || sceneIndex == 5 || sceneIndex == 6 || sceneIndex == 13)
        {
            combatScene = true;
            lobbyScene = false;
            raceScene = false;
            multiplayer = false;
        }
        if (sceneIndex == 11)
        {
            lobbyScene = true;
            raceScene = false;
            combatScene = false;
            multiplayer = false;
        }
        if (sceneIndex == 10)
        {
            multiplayer = true;
            raceScene = false;
            combatScene = false;
            lobbyScene = false;

        }
    }
}

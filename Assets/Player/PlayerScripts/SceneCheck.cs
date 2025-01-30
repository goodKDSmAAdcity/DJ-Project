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
    public GameObject Player;
    void Update()
    {
    sceneIndex= SceneManager.GetActiveScene().buildIndex;
    if(sceneIndex==2 || sceneIndex==4 || sceneIndex==7)
        raceScene=true;
    if(sceneIndex==3 || sceneIndex==5 || sceneIndex==6)
        combatScene=true;
    if(sceneIndex==11)
        lobbyScene=true;
        if (sceneIndex == 7)
        {
            Player.transform.position =new Vector3(0f,transform.position.y,transform.position.z);
        }
    }
}

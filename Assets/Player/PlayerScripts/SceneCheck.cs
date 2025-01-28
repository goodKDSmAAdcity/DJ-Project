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
    void Update()
    {
    sceneIndex= SceneManager.GetActiveScene().buildIndex;
    if(sceneIndex==2 || sceneIndex==4)
        raceScene=true;
    if(sceneIndex==3 || sceneIndex==5)
        combatScene=true;
    if(sceneIndex==11)
        lobbyScene=true;
    }
}

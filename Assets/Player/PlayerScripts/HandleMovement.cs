using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HandleMovement : MonoBehaviour
{
    public SceneCheck sceneCheck;
    public Follow toggleFollow;
    public Weapon toggleWeapon;
    public Movement toggleMovement;
    public FollowRotation toggleFollowRotation;
    public FollowMouse toggleFollowMouse;
    public PlayerMouseRotation togglePlayerMouseRotation;
    public PauseMenu1 pauseMenu;
    public AsteroidCollision death;
    public GameObject Player;
    public bool isPausedByMenu;
    void Start()
    {
        if (sceneCheck.multiplayer == false)
        {
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        // Call the method that will run one frame later
        StartCoroutine(RunOneFrameAfterStart());
    }

    private IEnumerator RunOneFrameAfterStart()
    {
        // Wait until the next frame
        yield return null;

        // This code runs one frame after Start
        if(sceneCheck.raceScene==true){
            Player.transform.rotation = Quaternion.Euler(0, 0, 0);
            toggleFollow.enabled=false;
            toggleWeapon.enabled=false;
            toggleMovement.enabled=true;
            toggleFollowRotation.enabled = false;
            toggleFollowMouse.enabled=false;
            togglePlayerMouseRotation.enabled = false;
        }   
                if(sceneCheck.combatScene==true){
            toggleFollow.enabled=false;
            toggleWeapon.enabled=true;
            toggleMovement.enabled=true;
            toggleFollowRotation.enabled=true;
            toggleFollowMouse.enabled=false;
            togglePlayerMouseRotation.enabled=true;
        }   
            if(sceneCheck.lobbyScene==true){
            toggleFollow.enabled=true;
            toggleWeapon.enabled=true;
            toggleMovement.enabled=false;
            toggleFollowRotation.enabled=false;
            toggleFollowMouse.enabled=false;
            togglePlayerMouseRotation.enabled=false;  
            sceneCheck.raceScene= false;
            sceneCheck.combatScene= false;
            }
        if (sceneCheck.multiplayer == true)
        {
            toggleFollow.enabled = false;
            toggleWeapon.enabled = true;
            toggleMovement.enabled = true;
            toggleFollowRotation.enabled = false;
            toggleFollowMouse.enabled = false;
            togglePlayerMouseRotation.enabled = false;
        }
    }
    void Update()
    {
        if ( (pauseMenu.GameIsPaused == true || isPausedByMenu==true) || death.isDead==true)
        {
            toggleFollow.enabled = false ;
            toggleWeapon.enabled = false;
            toggleMovement.enabled = false;
            toggleFollowRotation.enabled = false;
            toggleFollowMouse.enabled = false;
            togglePlayerMouseRotation.enabled = false;
        }
        else
        {
            if (sceneCheck.raceScene == true)
            {
                Player.transform.rotation = Quaternion.Euler(0, 0, 0);
                sceneCheck.combatScene = false;
                sceneCheck.lobbyScene = false;
                toggleFollow.enabled = false;
                toggleWeapon.enabled = false;
                toggleMovement.enabled = true;
                toggleFollowRotation.enabled = false;
                toggleFollowMouse.enabled = false;
                togglePlayerMouseRotation.enabled = false;
            }
            if (sceneCheck.combatScene == true)
            {
                sceneCheck.raceScene = false;
                sceneCheck.lobbyScene = false;
                toggleFollow.enabled = false;
                toggleWeapon.enabled = true;
                toggleMovement.enabled = true;
                toggleFollowRotation.enabled = true;
                toggleFollowMouse.enabled = false;
                togglePlayerMouseRotation.enabled = true;
            }
            if (sceneCheck.lobbyScene == true)
            {
                sceneCheck.raceScene = false;
                sceneCheck.combatScene = false;
                toggleFollow.enabled = true;
                toggleWeapon.enabled = true;
                toggleMovement.enabled = false;
                toggleFollowRotation.enabled = false;
                toggleFollowMouse.enabled = false;
                togglePlayerMouseRotation.enabled = false;
            }
        }
    }
}

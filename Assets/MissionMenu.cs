using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionMenu : MonoBehaviour
{
    public bool GameIsPaused;
    public GameObject MenuUI;
    public InteractRange ir;
    public PauseMenu1 pm;
    public HandleMovement hm;
    public int mission1;
    public int mission2;
    public int mission3;
    public Missions missions;
    public SceneCheck sc;
    private void Start()
    {
        GameIsPaused = false;
        Time.timeScale = 1.0f;
    }
    void Update()
    {
        if (ir.canInteract==true && Input.GetKeyDown(KeyCode.E) && pm.GameIsPaused==false)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        hm.isPausedByMenu = false;
        pm.enabled = true;
        MenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        hm.isPausedByMenu = true;
        pm.enabled= false;
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Mission1()
    {
        GameIsPaused = false;
        SceneManager.LoadScene(mission1);
    }

    public void Mission2()
    {
        GameIsPaused= false;
        SceneManager.LoadScene(mission2);
    }
    public void Mission3()
    {
        GameIsPaused = false;
        SceneManager.LoadScene(mission3);
    }

    public void Options()
    {

    }
}

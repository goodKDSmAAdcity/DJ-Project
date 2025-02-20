using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Missions : MonoBehaviour
{
    public SceneCheck scenec;
    private int sceneIndex;
    public bool[] r = new bool[] { false, false, false };
    public bool[] c= new bool[] {false,false,false};
    public bool bossunlock= false;
    public FinishLine mission;
    public bool isPurchased = false;
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void Update()
    {
        sceneIndex = scenec.sceneIndex;
        if (mission.MissionComplete)
        {
            if (sceneIndex == 2)
            {
                r[0] = true;              
                SceneManager.LoadScene(11); // 11 lobby
            }
            if (sceneIndex == 4)
            {
                r[1] = true;

                SceneManager.LoadScene(11);
            }
            if (sceneIndex == 12)
            {
                r[2] = true;

                SceneManager.LoadScene(11);
            }
            if (sceneIndex == 7)
            {
                SceneManager.LoadScene(8); // 8 ending
            }
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene Loaded: " + scene.name);
            Find();
    }

    private void Find()
    {
        mission = FindObjectOfType<FinishLine>();
    }
}

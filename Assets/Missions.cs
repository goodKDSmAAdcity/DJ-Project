using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Missions : MonoBehaviour
{
    public SceneCheck scene;
    private int sceneIndex;
    public bool r1 = false;
    public bool r2 = false;
    public bool r3 = false;
    public bool c1 = false;
    public bool c2 = false;
    public bool c3 = false;
    public bool bossunlock= false;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FinishLine"))
        {
            if(sceneIndex==1) 
            {
                r1 = true;
                SceneManager.LoadScene(11); // 11 lobby
            }
            if(sceneIndex==2)
            {
                r2 = true;
                SceneManager.LoadScene(11);
            }
            if (sceneIndex == 3)
            {
                r3 = true;
                SceneManager.LoadScene(11);
            }
            if (sceneIndex == 7)
            {
                SceneManager.LoadScene(8); // 8 ending
            }
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        sceneIndex= scene.sceneIndex;
    }
}

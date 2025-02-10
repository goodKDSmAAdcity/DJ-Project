using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HandleScore : MonoBehaviour
{
    public SceneCheck scene;
    public int score;
    public monsterSpawner kills;
    public TMP_Text sc;
    private float timer = 0f;
    private float interval = 1f;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
       score= 0;
    }

    // Update is called once per frame
    void Update()
    {
        sc.text= "Score: " + score.ToString();
        if(scene.raceScene==true) 
        {
            timer += Time.deltaTime;
            if(timer >=interval)
            {
                score +=(int)Random.Range(4f, 17f);
                timer = 0f;
            }
        }
        if (scene.sceneIndex==1)
        {
            score = 0;
        }
    }
}

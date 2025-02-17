using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using System.Net.NetworkInformation;
using UnityEngine.SceneManagement;

public class monsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab; // Prefab of the monster to spawn
    public float spawnInterval = 2f; // Time interval between spawns
    public int maxMonsters = 5; // Maximum number of monsters to spawn
    public float spawnXPosition = 3f; // Y position where monsters spawn
    public float time=0;
    public float NOfEnemies = 30;
    public int Kills = 0;
    public TMP_Text cnt;
    private float TotalSpawned = 0;
    public int nextScene;
    public HandleScore score;
    public Missions mission;
    public SceneCheck sc;
    private int currentMonsterCount = 0; // Current number of spawned monsters
    private float timer = 0f; // Timer to track spawn intervals

    void Update()
    {
        cnt.text = "Kills: " + Kills.ToString() + " /" + NOfEnemies.ToString(); 
        if (time > 10)
        {
            spawnInterval = 1.5f;
        }
        if (time > 20)
        {
            spawnInterval = 1f;
        }
        // Check if the maximum number of monsters has not been reached and if it's time to spawn a new one
        if (currentMonsterCount < maxMonsters && timer >= spawnInterval && Kills<=NOfEnemies && TotalSpawned+1<=NOfEnemies)
        {
            // Spawn a monster
            SpawnMonster();
            // Reset the timer
            timer = 0f;
        }
        if(Kills >= NOfEnemies)
        {
            if(sc.sceneIndex==3) 
            {
                mission.c[0] = true;
            }
            if(sc.sceneIndex==5) 
            {
                mission.c[1] = true;
            }
            if (sc.sceneIndex == 13)
            {
                mission.c[2] = true;
            }
            SceneManager.LoadScene(11);
        }

        // Update the timer
        time += Time.deltaTime;
        timer += Time.deltaTime;
    }

    void SpawnMonster()
    {
        // Generate a random x position within the spawn area
        float spawnYPosition = transform.position.y;

        // Instantiate the monster at the spawn position
        GameObject newMonster = Instantiate(monsterPrefab, new Vector3(spawnXPosition, Random.Range(-4f,4f), 0f), Quaternion.identity);

        // Increase the current monster count
        currentMonsterCount++;
        TotalSpawned++;
        // Attach a callback to the monster's OnDestroy event to decrease the count when it's destroyed
        newMonster.GetComponent<Enemy>().OnDestroyed += () => { currentMonsterCount--; Kills++; score.score+=(int)(100*Random.RandomRange(0.6f,1.4f)); };
    }

}

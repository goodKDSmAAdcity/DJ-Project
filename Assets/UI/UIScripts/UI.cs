using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour

{
    public SceneCheck scene;
    public int PlayerID;
    public GameObject canvas;
    public TextMeshProUGUI text;

    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void Start()
    {

        HandleSceneChange(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        HandleSceneChange(scene.buildIndex);
    }

    private void HandleSceneChange(int sceneIndex)
    {

        text.enabled = sceneIndex == 1;
        if (sceneIndex == 1)
        {
            PlayerID = Random.Range(1, 999);
            int aux = PlayerID;
            text.text = $"Will Pilot {aux} become a new hero?";
            PlayerID= aux;
            Debug.Log(PlayerID);
        }

        bool HideScore = sceneIndex == 10 || sceneIndex == 0 || sceneIndex == 1 || sceneIndex == 8 || sceneIndex == 9 || sceneIndex==6 || sceneIndex==7;
        canvas.SetActive(!HideScore);
        
    }
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}


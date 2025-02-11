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


        if (sceneIndex == 1)
        {
            text=FindObjectOfType<TextMeshProUGUI>();
            PlayerID = Random.Range(1, 999);
            int aux = PlayerID;
            
            text.text = $"Will Pilot {aux} become a new hero?";
            PlayerID= aux;
            Debug.Log(PlayerID);
        }

        bool HideCanvas = sceneIndex == 10 || sceneIndex == 0 || sceneIndex == 1 || sceneIndex == 8 || sceneIndex == 9;
        canvas.SetActive(!HideCanvas);
    }
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}


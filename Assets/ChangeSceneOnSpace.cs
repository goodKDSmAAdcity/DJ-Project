using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnSpace : MonoBehaviour
{
    public string sceneName; // Assign the scene name to load in the Inspector

    void Update()
    {
        // Check if the Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
}

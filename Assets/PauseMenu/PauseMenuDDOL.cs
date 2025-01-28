using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuDDOL : MonoBehaviour
{
    private static PauseMenuDDOL instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

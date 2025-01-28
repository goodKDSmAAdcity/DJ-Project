using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDDOL : MonoBehaviour
{

    private static PlayerDDOL instance;

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

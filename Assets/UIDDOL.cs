using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDDOL : MonoBehaviour
{
    private static UIDDOL instance;

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

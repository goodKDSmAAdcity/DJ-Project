using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int nameID;
    public SceneCheck SceneIndex;
    private float sceneIndex;
    void Start()
    {
        nameID = UnityEngine.Random.Range(1, 100);
    }


    

}

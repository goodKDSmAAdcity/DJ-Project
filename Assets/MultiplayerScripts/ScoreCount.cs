using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public Player P1;
    public Player P2;
    private int deathCount1 = 0;
    private int deathCount2 = 0;
    void Start()
    {
        P1.OnDestroyed += P1_OnDestroyed;
        P2.OnDestroyed += P2_OnDestroyed;
    }

    private void P2_OnDestroyed()
    {
        deathCount2++;
    }

    private void P1_OnDestroyed()
    {
        deathCount1++;
    }

    void Update()
    {
        
    }
}

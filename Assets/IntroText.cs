using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Player player;

    void Start()
    {
        StartCoroutine(RunOneFrameAfterStart());
    }

    private IEnumerator RunOneFrameAfterStart()
    {
        yield return null;
        text.text = "Will Pilot "  + " become a new hero?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

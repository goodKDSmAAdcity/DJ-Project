using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;


    // Update is called once per frame
    void Update()
    {
        source.PlayOneShot(clip);
    }
}

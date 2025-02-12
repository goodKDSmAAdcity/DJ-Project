using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;
using UnityEngine.UI;

public class SetVolumeStart : MonoBehaviour
{
    private AudioSource audioSource;
    public Slider slider;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();

        float savedVolume = PlayerPrefs.GetFloat("VolumeLevel",0.5f); 
        StartCoroutine(SetSliderAfterDelay(savedVolume));

    }

    IEnumerator SetSliderAfterDelay(float volume)
    {
        yield return new WaitForSeconds(0.1f);
        slider.SetValueWithoutNotify(volume);
    }
}

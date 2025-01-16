using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableButton : MonoBehaviour
{
    public GameObject Button;
    private void Start()
    {
        Button.SetActive(false);
    }
}

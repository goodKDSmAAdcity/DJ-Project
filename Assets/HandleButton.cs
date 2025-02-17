using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HandleButton : MonoBehaviour
{
    public bool btnIsCancelled;
    public int btnIndex;
    public TextMeshProUGUI btnText;
    public Button btn;
    public Missions mission;
    void Start()
    {
        mission = FindAnyObjectByType<Missions>();
        if(btnIndex<3)
        {
            if (mission.r[btnIndex])
                btnIsCancelled= true;
        }
        else
        {
            if (mission.c[btnIndex-3])
            {
                btnIsCancelled= true;
            }

        }
        if (btnIsCancelled)
        {
            CancelBtn();
        }
    }
    void CancelBtn()
    {
        if (btnIsCancelled)
        {
            btnText.text = "Mission Complete";
            btn.interactable= false;
        }
    }
}

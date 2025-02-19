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
    public bool isBossMenu;
    public bool missionUnlocked = false;
    void Start()
    {
        mission = FindAnyObjectByType<Missions>();
        if (isBossMenu==false)
        {
            if (btnIndex < 3)
            {
                if (mission.r[btnIndex])
                    btnIsCancelled = true;
            }
            else
            {
                if (mission.c[btnIndex - 3])
                {
                    btnIsCancelled = true;
                }

            }
            if (btnIsCancelled)
            {
                CancelBtn();
            }
        }
        if(isBossMenu==true)
        {
            if (mission.c[0] && mission.c[1] && mission.c[2] && mission.r[0] && mission.r[1] && mission.r[2])
            {
                missionUnlocked= true;
            }
            if (missionUnlocked == false)
            {
                btnText.text = "COMPLETE ALL MISSIONS TO UNLOCK THE FINAL MISSION";
                btn.interactable = false;
            }
        }
    }
    void CancelBtn()
    {
        if (btnIsCancelled)
        {
            btnText.text = "MISSION COMPLETE";
            btn.interactable= false;
        }
    }
}

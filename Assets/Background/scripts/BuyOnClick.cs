using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyOnClick : MonoBehaviour
{
    MoneyCalling A;
    public Button Button;
    public Image I;
    public void Clicked1()
    {
        A = GameObject.FindGameObjectWithTag("Currency").GetComponent<MoneyCalling>();
        A.Buy(2);
        I.color = new Color32(255, 255, 225, 100);
        Button.enabled = false;
    }
    public void Clicked2()
    {
        A = GameObject.FindGameObjectWithTag("Currency").GetComponent<MoneyCalling>();
        A.Buy(3);
        I.color = new Color32(255, 255, 225, 100);
        Button.enabled = false;
    }
}

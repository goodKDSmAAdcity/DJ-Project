using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCalling : MonoBehaviour
{
    private int Currency=0;
    public Button MyButton;
    private TMP_Text Coins;
    void GetCash(int Price)
    {
        Currency += Price;
    }
    public void Buy(int Price)
    {
        if (Currency >= Price)
        {
            MyButton.interactable = true;
            Currency -= Price;
        }
        else
        {
            MyButton.interactable = false;
        }
    }
    private void Awake()
    {
        Coins = GetComponent<TMP_Text>();
        Coins.text = "0";
    }
    private void Update()
    {
        Coins.text=Currency.ToString();
    }
}

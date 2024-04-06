using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyCalling : MonoBehaviour
{
    private int Currency=0;
    private TMP_Text Coins;
    void GetCash(int Price)
    {
        Currency += Price;
    }
    public void Buy(int Price)
    {
        if (Currency >= Price)
            Currency -= Price;
        else
            Debug.Log("Bad");
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

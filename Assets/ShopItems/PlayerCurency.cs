using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int coins = 100; 

    public bool SpendCoins(int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
            return true;
        }
        return false;
    }
}

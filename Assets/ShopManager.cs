using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ShopManager : MonoBehaviour
{
    public GameObject shopItemPrefab; // Reference to the item prefab
    public Transform shopContent;    // The content area of the Scroll View
    public List<ShopItem> items;     // List of all shop items

    void Start()
    {
        PopulateShop();
    }

    void PopulateShop()
    {
        foreach (ShopItem item in items)
        {
            GameObject newItem = Instantiate(shopItemPrefab, shopContent);
            newItem.transform.Find("ItemName").GetComponent<Text>().text = item.itemName;
            newItem.transform.Find("Price").GetComponent<Text>().text = item.price.ToString();
            newItem.transform.Find("Icon").GetComponent<Image>().sprite = item.icon;

            newItem.GetComponent<Button>().onClick.AddListener(() => BuyItem(item));
        }
    }

    void BuyItem(ShopItem item)
{
    PlayerData playerData = FindObjectOfType<PlayerData>();

    if (playerData.SpendCoins(item.price))
    {
        Debug.Log($"Bought {item.itemName}");
        // Add the item to the player's inventory here
    }
    else
    {
        Debug.Log("Not enough coins!");
    }
}

}

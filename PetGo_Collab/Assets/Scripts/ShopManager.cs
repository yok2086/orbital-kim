using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public MoneyManager MoneyManager;
    public InventoryManager InventoryManager;

    private int[] prices = { 1000, 2000, 3000, 4000, 500, 600 };
    // Start is called before the first frame update
  
    public void BuyItem(int itemCode)
    {
        InventoryManager.additem(itemCode);
        MoneyManager.MinusMoney(prices[itemCode]);
    }
}

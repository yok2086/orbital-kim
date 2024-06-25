using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ShopManager : MonoBehaviour
{
    public MoneyManager MoneyManager;
    public InventoryManager InventoryManager;
    public TextManager TextManager;
    private int[] prices = { 1000, 2000, 3000, 4000, 500, 600 };
    // Start is called before the first frame update
  
    public void BuyItem(int itemCode)
    {
        bool result = MoneyManager.minusMoney(prices[itemCode]);
        if (result)
        {
            InventoryManager.addItem(itemCode);
        }
        else
        {
            TextManager.DisplayTextForSeconds(2);
        }
    }
}

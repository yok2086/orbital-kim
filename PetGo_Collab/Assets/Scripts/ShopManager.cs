using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class ShopManager : MonoBehaviour
{
    public MoneyManager MoneyManager;
    public InventoryManager InventoryManager;
    public TextManager TextManager;
    private int[] prices = { 
        1000, // banana
        2000, //egg
        3000, // apple
        4000, // watermelon
        500,  // salmon
        600,  // chicken
        20000,// black
        20000,// pink
        5000, // red
        5000, // yellow
        5000, // blue
        15000,// sunglasses
        20000,// ribbon
        10000, // bone
        35000 // ball
    };
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

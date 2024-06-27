using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedingManager : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public HPUI hpUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Feed(int itemCode)
    {
        bool result = inventoryManager.useItem(itemCode);

        if(result)
        {
            hpUI.Eat();
        }
    }
}

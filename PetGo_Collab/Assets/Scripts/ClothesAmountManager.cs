using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClothesAmountManager : MonoBehaviour
{
    public TextMeshProUGUI blackAmountText;
    public InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blackAmountText.text = inventoryManager.GetItemAmount(6).ToString();
    }
}

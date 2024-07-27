using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClothesAmountManager : MonoBehaviour
{
    public TextMeshProUGUI blackAmountText;
    public TextMeshProUGUI pinkAmountText;

    public TextMeshProUGUI redAmountText;
    public TextMeshProUGUI yellowAmountText;
    public TextMeshProUGUI blueAmountText;
    public TextMeshProUGUI sunglassesAmountText;
    public TextMeshProUGUI ribbonAmountText;
    public TextMeshProUGUI boneAmountText;
    public TextMeshProUGUI ballAmountText;
    public InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blackAmountText.text = inventoryManager.GetItemAmount(6).ToString();
        pinkAmountText.text = inventoryManager.GetItemAmount(7).ToString();
        redAmountText.text = inventoryManager.GetItemAmount(8).ToString();
        yellowAmountText.text = inventoryManager.GetItemAmount(9).ToString();
        blueAmountText.text = inventoryManager.GetItemAmount(10).ToString();
        sunglassesAmountText.text = inventoryManager.GetItemAmount(11).ToString();
        ribbonAmountText.text = inventoryManager.GetItemAmount(12).ToString();
        boneAmountText.text = inventoryManager.GetItemAmount(13).ToString();
        ballAmountText.text = inventoryManager.GetItemAmount(14).ToString();

    }
}

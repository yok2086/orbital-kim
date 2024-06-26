using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AmountManager : MonoBehaviour
{
    public TextMeshProUGUI bananaAmountText;
    public TextMeshProUGUI eggAmountText;
    public TextMeshProUGUI appleAmountText;
    public TextMeshProUGUI waterMelonAmountText;
    public TextMeshProUGUI salmonAmountText;
    public TextMeshProUGUI chickenAmountText;

    public InventoryManager inventoryManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bananaAmountText.text = inventoryManager.GetItemAmount(0).toString();
        eggAmountText.text = inventoryManager.GetItemAmount(1).toString();
        appleAmountText.text = inventoryManager.GetItemAmount(2).toString();
        waterMelonAmountText.text = inventoryManager.GetItemAmount(3).toString();
        salmonAmountText.text = inventoryManager.GetItemAmount(4).toString();
        chickenAmountText.text = inventoryManager.GetItemAmount(5).toString();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InventoryManager : MonoBehaviour
{
    int[] items = new int[6];
    // Start is called before the first frame update
    void Start()
    {
        items[0] = PlayerPrefs.GetInt("bananaAmount", 0);
        items[1] = PlayerPrefs.GetInt("eggAmount", 0);
        items[2] = PlayerPrefs.GetInt("appleAmount", 0);
        items[3] = PlayerPrefs.GetInt("waterMelonAmount", 0);
        items[4] = PlayerPrefs.GetInt("salmonAmount", 0);
        items[5] = PlayerPrefs.GetInt("chickenAmount", 0);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("bananaAmount", items[0]);
        PlayerPrefs.SetInt("eggAmount", items[1]);
        PlayerPrefs.SetInt("appleAmount", items[2]);
        PlayerPrefs.SetInt("waterMelonAmount", items[3]);
        PlayerPrefs.SetInt("salmonAmount", items[4]);
        PlayerPrefs.SetInt("chickenAmount", items[5]);

    }

    public void addItem(int itemCode)
    {
        items[itemCode] += 1;
    }

    public int GetItemAmount(int itemCode)
    {
        return items[itemCode];
    }

    public bool useItem(int itemCode)
    {
        if (items[itemCode]==0)
        {
            return false;
        }

        else
        {
            items[itemCode]--;
            return true;
        }
    }
}


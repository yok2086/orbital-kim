using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InventoryManager : MonoBehaviour
{
    int[] items = new int[15];
    // Start is called before the first frame update
    void Start()
    {
        items[0] = PlayerPrefs.GetInt("bananaAmount", 5);
        items[1] = PlayerPrefs.GetInt("eggAmount", 0);
        items[2] = PlayerPrefs.GetInt("appleAmount", 0);
        items[3] = PlayerPrefs.GetInt("waterMelonAmount", 0);
        items[4] = PlayerPrefs.GetInt("salmonAmount", 0);
        items[5] = PlayerPrefs.GetInt("chickenAmount", 0);
        //
        items[6] = PlayerPrefs.GetInt("blackAmount", 0);
        items[7] = PlayerPrefs.GetInt("pinkAmount", 0);
        items[8] = PlayerPrefs.GetInt("redAmount", 0);
        items[9] = PlayerPrefs.GetInt("yellowAmount", 0);
        items[10] = PlayerPrefs.GetInt("blueAmount", 0);
        items[11] = PlayerPrefs.GetInt("sunglassesAmount", 0);
        items[12] = PlayerPrefs.GetInt("ribbonAmount", 0);
        items[13] = PlayerPrefs.GetInt("boneAmount", 0);
        items[14] = PlayerPrefs.GetInt("ballAmount", 0);

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
        //
        PlayerPrefs.SetInt("blackAmount", items[6]);
        PlayerPrefs.SetInt("pinkAmount", items[7]);
        PlayerPrefs.SetInt("redAmount", items[8]);
        PlayerPrefs.SetInt("yellowAmount", items[9]);
        PlayerPrefs.SetInt("blueAmount", items[10]);
        PlayerPrefs.SetInt("sunglassesAmount", items[11]);
        PlayerPrefs.SetInt("ribbonAmount", items[12]);
        PlayerPrefs.SetInt("boneAmount", items[13]);
        PlayerPrefs.SetInt("ballAmount", items[14]);

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
        if (items[itemCode] == 0)
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


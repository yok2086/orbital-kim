using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClothesInvManager : MonoBehaviour
{
    int[] items = new int[9];
    // Start is called before the first frame update
    void Start()
    {
        items[0] = PlayerPrefs.GetInt("blackAmount", 0);
        items[1] = PlayerPrefs.GetInt("pinkAmount", 0);
        items[2] = PlayerPrefs.GetInt("redAmount", 0);
        items[3] = PlayerPrefs.GetInt("yellowAmount", 0);
        items[4] = PlayerPrefs.GetInt("blueAmount", 0);
        items[5] = PlayerPrefs.GetInt("sunglassesAmount", 0);
        items[6] = PlayerPrefs.GetInt("ribbonAmount", 0);
        items[7] = PlayerPrefs.GetInt("boneAmount", 0);
        items[8] = PlayerPrefs.GetInt("ballAmount", 0);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("blackAmount", items[0]);
        PlayerPrefs.SetInt("pinkAmount", items[1]);
        PlayerPrefs.SetInt("redAmount", items[2]);
        PlayerPrefs.SetInt("yellowAmount", items[3]);
        PlayerPrefs.SetInt("blueAmount", items[4]);
        PlayerPrefs.SetInt("sunglassesAmount", items[5]);
        PlayerPrefs.SetInt("ribbonAmount", items[6]);
        PlayerPrefs.SetInt("boneAmount", items[7]);
        PlayerPrefs.SetInt("ballAmount", items[8]);
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


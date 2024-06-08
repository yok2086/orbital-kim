using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int playerLevel;
    public Text levelText; 

    [ContextMenu("Increase Score")]

    public void addLevel ()
    {
        playerLevel = playerLevel + 1;
        levelText.text = playerLevel.ToString();
    }

    void Update() 
    {
        // GameObject gameDirector = GameObject.Find("Game Director");
        // float width = gameDirector.GetComponent<GameDirector>().GetAmount();
        // if (width == 1f)
        // {
        //     addLevel();
        // }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleanBarUI : MonoBehaviour
{
    public Image cleanBarImage;

    public Gradient gradient;

    public float minHP = 0f;
    public float maxHP = 1f;
    public float points = 0.1f;

    void Start()
    {
        cleanBarImage.fillAmount = StaticData.cleanBar;
        //currentHP = StaticData.cleanBar;
      
    }

    // public void Eat()
    // {
    //     //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
    //     StaticData.hungryBar += points;
    // }
    public void Clean()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        StaticData.cleanBar += points;
        Debug.Log(points);
    }

    // public void Sleep()
    // {
    //     //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
    //     currentHP += 0.3f;
    // }

    // public void Nap()
    // {
    //     //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
    //     currentHP += points;
    // }

    // public void KeepcleanValue() 
    // {
    //     dataToKeep = currentHP; 
    //     StaticData.cleanBar = dataToKeep; 
    // }
    // public void KeepCleanValue() 
    // {
    //     dataToKeep = currentHP; 
    //     StaticData.cleanBar = dataToKeep; 
    // }
    // public void KeepSleepValue() 
    // {
    //     dataToKeep = currentHP; 
    //     StaticData.sleepBar = dataToKeep; 
    // }


    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButton(0))
        //{
        cleanBarImage.fillAmount = StaticData.cleanBar;
        //Debug.Log("space key pressed");
        //}
        //filledBar.fillamount = currentHP / maxHP;
        cleanBarImage.color = gradient.Evaluate(cleanBarImage.fillAmount);
        // Debug.Log(dataToKeep); 
        //currentHP = StaticData.cleanBar; /////////
    } 
}

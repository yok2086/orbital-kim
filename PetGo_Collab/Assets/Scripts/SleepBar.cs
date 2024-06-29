using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepBarUI : MonoBehaviour
{
    public Image sleepBarImage;

    public Gradient gradient;

    public float minHP = 0f;
    public float maxHP = 1f;
    public float points = 0.1f;
    
    void Start()
    {
        sleepBarImage.fillAmount = StaticData.sleepBar;
        //currentHP = StaticData.sleepBar;
      
    }

    // public void Eat()
    // {
    //     //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
    //     StaticData.hungryBar += points;
    // }
    public void Sleep()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        StaticData.sleepBar += points;
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

    // public void KeepsleepValue() 
    // {
    //     dataToKeep = currentHP; 
    //     StaticData.sleepBar = dataToKeep; 
    // }
    // public void KeepsleepValue() 
    // {
    //     dataToKeep = currentHP; 
    //     StaticData.sleepBar = dataToKeep; 
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
        sleepBarImage.fillAmount = StaticData.sleepBar;
        //Debug.Log("space key pressed");
        //}
        //filledBar.fillamount = currentHP / maxHP;
        sleepBarImage.color = gradient.Evaluate(sleepBarImage.fillAmount);
        // Debug.Log(dataToKeep); 
        //currentHP = StaticData.sleepBar; /////////
    } 
}

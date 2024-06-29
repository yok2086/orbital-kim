using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungryBarUI : MonoBehaviour
{
    public Image hungryBarImage;

    public Gradient gradient;

    public float minHP = 0f;
    public float maxHP = 1f;
    public float points = 0.5f;

    void Start()
    {
        hungryBarImage.fillAmount = StaticData.hungryBar;
        //currentHP = StaticData.hungryBar;
      
    }

    public void Eat()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        StaticData.hungryBar += points;
    }
    // public void Clean()
    // {
    //     //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
    //     currentHP += points;
    // }

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

    // public void KeepHungryValue() 
    // {
    //     dataToKeep = currentHP; 
    //     StaticData.hungryBar = dataToKeep; 
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
        hungryBarImage.fillAmount = StaticData.hungryBar;
        //Debug.Log("space key pressed");
        //}
        //filledBar.fillamount = currentHP / maxHP;
        hungryBarImage.color = gradient.Evaluate(hungryBarImage.fillAmount);
        // Debug.Log(dataToKeep); 
        //currentHP = StaticData.hungryBar; /////////
    } 
}

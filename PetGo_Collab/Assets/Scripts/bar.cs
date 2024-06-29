using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUI : MonoBehaviour
{
    public Image filledBar;

    public Gradient gradient;

    public float minHP = 0f;
    public float currentHP = 0f;
    public float maxHP = 1f;
    public float points = 0.1f;
    public float dataToKeep; 
    void Start()
    {
        currentHP = minHP;
        filledBar.fillAmount = currentHP;
        currentHP = StaticData.hungryBar;
      
    }

    public void Eat()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += points;
    }
    public void Clean()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += points;
    }

    public void Sleep()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += 0.3f;
    }

    public void Nap()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += points;
    }

    public void KeepHungryValue() 
    {
        dataToKeep = currentHP; 
        StaticData.hungryBar = dataToKeep; 
    }
    public void KeepCleanValue() 
    {
        dataToKeep = currentHP; 
        StaticData.cleanBar = dataToKeep; 
    }
    public void KeepSleepValue() 
    {
        dataToKeep = currentHP; 
        StaticData.sleepBar = dataToKeep; 
    }


    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButton(0))
        //{
            filledBar.fillAmount = currentHP;
        //Debug.Log("space key pressed");
        //}
        //filledBar.fillamount = currentHP / maxHP;
        filledBar.color = gradient.Evaluate(filledBar.fillAmount);
        // Debug.Log(dataToKeep); 
        //currentHP = StaticData.hungryBar; /////////
    } 
}

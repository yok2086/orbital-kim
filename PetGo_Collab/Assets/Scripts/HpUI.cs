using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUI : MonoBehaviour
{
    public Image filledBar;

    public Gradient gradient;

    public string barName;
    public float minHP = 0f;
    public float currentHP = 0f;
    public float maxHP = 1f;
    public float points = 0.1f;
    void Start()
    {
  

    }

    public void AddBarGauge()
    {
        PlayerPrefs.SetFloat(barName, currentHP + points);

    }

    public void AddBarGauge(float points)
    {
        PlayerPrefs.SetFloat(barName, currentHP + points);

    }

    public bool isFull()
    {
        return filledBar.fillAmount == maxHP;


    }

    // Update is called once per frame
    void Update()
    {
        currentHP = PlayerPrefs.GetFloat(barName, minHP);
        filledBar.fillAmount = currentHP;
        filledBar.color = gradient.Evaluate(filledBar.fillAmount);
    }

 
}
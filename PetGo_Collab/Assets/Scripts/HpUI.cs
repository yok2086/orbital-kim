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
        //PlayerPrefs.SetFloat(barName, 0);
        currentHP = PlayerPrefs.GetFloat(barName, minHP);
        
    }

    public void AddBarGauge()
    {
        currentHP += points;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat(barName, currentHP);
        filledBar.fillAmount = currentHP;
        filledBar.color = gradient.Evaluate(filledBar.fillAmount);
    } 
}

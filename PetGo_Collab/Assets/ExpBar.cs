using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExpBar : MonoBehaviour
{
    public Slider slider; 
    public Gradient gradient;
    public Image fill;
   
    public void SetMaxVaue(int value)
    {
        slider.maxValue = value;
        fill.color = gradient.Evaluate(1f); 
    }
    public void SetMinVaue(int value)
    {
        slider.minValue = value;
    }

    public int GetCurrentValue()
    {
        return (int)slider.value;
    }
    public void SetValue(int value)
    {
        slider.value = value;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}

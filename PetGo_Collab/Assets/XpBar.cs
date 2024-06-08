using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class XpBar: MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider; 
   
    public void SetMaxVaue(int value)
    {
        slider.maxValue = value;
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
    }
}

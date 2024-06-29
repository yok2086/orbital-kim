using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class SliderController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText = null;
    [SerializeField] private float maxSliderAmount = 200.0f;
    private float expNum = 0.0f; 

    public void SliderChange (float value)
    {
        float expNum = value * maxSliderAmount;
        sliderText.text = expNum.ToString("0");  
    }

}

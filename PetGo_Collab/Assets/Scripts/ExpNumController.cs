using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ExpNumController : MonoBehaviour
{
    public Slider slider;
    public float sliderVal;
    private float level;
    public float levelVal;
    private float expNum = 0.0f;
    public MoneyManager MoneyManager;

    
    [SerializeField] private TextMeshProUGUI levelText = null;
    [SerializeField] private TextMeshProUGUI sliderText = null;
    [SerializeField] private float maxSliderAmount = 200.0f;


    //public int sample; 

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("sliderVal", 0);
        levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
    }

    public void SliderChange(float value)
    {
        float expNum = value * maxSliderAmount;
        sliderText.text = expNum.ToString("0");
    }


    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("switch", 0) == 1)
        {
            levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
            slider.value = PlayerPrefs.GetFloat("sliderVal", 0);
            sliderText.text = PlayerPrefs.GetFloat("sliderVal", 0).ToString();
            PlayerPrefs.SetInt("HungryRef", 1); //true
            PlayerPrefs.SetInt("CleanRef", 1); //true
            PlayerPrefs.SetInt("SleepRef", 1); //true
            PlayerPrefs.SetInt("switch", 0);
        }
        else
        {

            if (PlayerPrefs.GetFloat("HungryBar", 0) >= 1.0f && PlayerPrefs.GetInt("HungryRef", 0) == 1) 
            {
                slider.value += 0.3f;
                PlayerPrefs.SetInt("HungryRef", 0); //true
            } else if (PlayerPrefs.GetFloat("HungryBar", 0) < 1.0f) {
                PlayerPrefs.SetInt("HungryRef", 1); 
            }

            if (PlayerPrefs.GetFloat("CleanBar", 0) >= 1.0f && PlayerPrefs.GetInt("CleanRef", 0) == 1) 
            {
                slider.value += 0.3f;
                PlayerPrefs.SetInt("CleanRef", 0); //true
            } else if (PlayerPrefs.GetFloat("CleanBar", 0) < 1.0f) {
                PlayerPrefs.SetInt("CleanRef", 1); 
            }

            if (PlayerPrefs.GetFloat("SleepBar", 0) >= 1.0f && PlayerPrefs.GetInt("SleepRef", 0) == 1) 
            {
                slider.value += 0.3f;
                PlayerPrefs.SetInt("SleepRef", 0); //true
            } else if (PlayerPrefs.GetFloat("SleepBar", 0) < 1.0f) {
                PlayerPrefs.SetInt("SleepRef", 1); 
            }

            if (slider.value >= 1.0f)
            {
                PlayerPrefs.SetFloat("levelVal", PlayerPrefs.GetFloat("levelVal", 0) + 1.0f);
                levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
                slider.value = 0.0f;
                MoneyManager.addMoney(20000);
            }
            PlayerPrefs.SetFloat("sliderVal", slider.value);
        }
    }


}

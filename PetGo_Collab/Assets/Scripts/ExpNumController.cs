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
        // slider.value = StaticData.sliderValue; //slider = GameObject.Find("XpBar").GetComponent<Slider>();
        // levelText.text = StaticData.levelValue.ToString();//level = 0; 
        //PlayerPrefs.SetFloat("sliderVal",0);
        slider.value = PlayerPrefs.GetFloat("sliderVal", 0);
        Debug.Log(slider.value);
        levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
    }

    public void SliderChange (float value)
    {
        float expNum = value * maxSliderAmount;
        sliderText.text = expNum.ToString("0");  
        Debug.Log("slider value =" + expNum);
    }


    // Update is called once per frame
    void Update()
    {
        
        // if (StaticData.hungryBar >= 1.0f) {
        //     slider.value += 0.5f;
        //     StaticData.hungryBar = 0.0f;
        // }
        // if (StaticData.cleanBar >= 1.0f) {
        //     slider.value += 0.05f;
        //     StaticData.cleanBar = 0.0f; 
        // }
        // if (StaticData.sleepBar >= 1.0f) {
        //     slider.value += 0.05f;
        //     StaticData.sleepBar = 0.0f; 
        // }
        if (PlayerPrefs.GetFloat("HungryBar", 0)>= 1.0f) {
            slider.value += 0.3f;
            PlayerPrefs.SetFloat("HungryBar", 0);
        }
        if (PlayerPrefs.GetFloat("CleanBar", 0) >= 1.0f) {
            slider.value += 0.3f;
            PlayerPrefs.SetFloat("CleanBar", 0);
        }
        if (PlayerPrefs.GetFloat("SleepBar", 0) >= 1.0f) {
            slider.value += 0.3f;
            PlayerPrefs.SetFloat("SleepBar", 0);
        }

        if(slider.value >= 1.0f) {
            //level += 1;
            //StaticData.levelValue += 1;
            //PlayerPrefs.GetFloat("levelVal", 0) += 1;
            PlayerPrefs.SetFloat("levelVal", PlayerPrefs.GetFloat("levelVal",0) + 1.0f);
            //PlayerPrefs.SetFloat("levelVal", level);
            //levelText.text = StaticData.levelValue.ToString();
            levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
            //StaticData.levelValue = level; 

            slider.value = 0.0f;
            MoneyManager.addMoney(20000); 
           // Debug.Log(StaticData.levelValue);

        }
        //StaticData.sliderValue = slider.value; 
        PlayerPrefs.SetFloat("sliderVal", slider.value);
        //PlayerPrefs.SetFloat("levelVal", level);


        
    }
}

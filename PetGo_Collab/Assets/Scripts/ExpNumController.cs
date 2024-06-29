using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpNumController : MonoBehaviour
{
    public Slider slider; 
    [SerializeField] private TextMeshProUGUI levelText = null;

    //public int level; 
    //public int sample; 

    void Start() 
    {
        slider.value = StaticData.sliderValue; //slider = GameObject.Find("XpBar").GetComponent<Slider>();
        levelText.text = StaticData.levelValue.ToString();//level = 0; 
        
    }


    // Update is called once per frame
    void Update()
    {
        
        if (StaticData.hungryBar >= 1.0f) {
            slider.value += 0.5f;
            StaticData.hungryBar = 0.0f;
        }
        if (StaticData.cleanBar >= 1.0f) {
            slider.value += 0.05f;
            StaticData.cleanBar = 0.0f; 
        }
        if (StaticData.sleepBar >= 1.0f) {
            slider.value += 0.05f;
            StaticData.sleepBar = 0.0f; 
        }

        if(slider.value >= 1.0f) {
            //level += 1;
            StaticData.levelValue += 1;
            levelText.text = StaticData.levelValue.ToString();
            
            //StaticData.levelValue = level; 

            slider.value = 0.0f;
            Debug.Log(StaticData.levelValue);

        }
        StaticData.sliderValue = slider.value; 

        
    }
}

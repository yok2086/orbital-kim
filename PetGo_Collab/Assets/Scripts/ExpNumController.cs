using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpNumController : MonoBehaviour
{
    public Slider slider; 
    //public int sample; 

    void Start() 
    {
        slider.value = 0.0f; //slider = GameObject.Find("XpBar").GetComponent<Slider>();
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
        if (StaticData.hungryBar >= 1.0f) {
            slider.value += 0.05f;
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
        
    }
}

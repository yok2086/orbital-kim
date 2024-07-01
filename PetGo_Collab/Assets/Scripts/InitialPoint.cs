using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPoint : MonoBehaviour 
{
    public void Switch() 
    {
        // DontDestroyOnLoad(this.gameObject);
        // PlayerPrefs.DeleteAll(); 
        // Debug.Log("Awake");
         // if (PlayerPrefs.GetInt("switch") == 0) {
            PlayerPrefs.SetFloat("sliderVal", 0f);
            PlayerPrefs.SetFloat("levelVal", 0f);
          //  PlayerPrefs.SetInt("Money", 20000);
            PlayerPrefs.SetFloat("HungryBar", 0f);
            PlayerPrefs.SetFloat("CleanBar", 0f);
            PlayerPrefs.SetFloat("SleepBar", 0f);
            

            PlayerPrefs.SetInt("switch",1);  
            PlayerPrefs.SetInt("MoneySwitch",0); 

            // GameObject.Find("UISliderController").AddComponent<MoneyManager>().Start(); 
            
        //} 
        //PlayerPrefs.SetInt("switch",0); 
    }

}
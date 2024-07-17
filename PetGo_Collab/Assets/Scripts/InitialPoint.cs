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
            //
            PlayerPrefs.SetInt("bananaAmount", 0);
            PlayerPrefs.SetInt("eggAmount", 0);
            PlayerPrefs.SetInt("appleAmount", 0);
            PlayerPrefs.SetInt("waterMelonAmount", 0);
            PlayerPrefs.SetInt("salmonAmount", 0);
            PlayerPrefs.SetInt("chickenAmount", 0);
            PlayerPrefs.SetInt("blackAmount", 0);
            PlayerPrefs.SetInt("pinkAmount", 0);
            PlayerPrefs.SetInt("redAmount", 0);
            PlayerPrefs.SetInt("yellowAmount", 0);
            PlayerPrefs.SetInt("blueAmount", 0);
            PlayerPrefs.SetInt("sunglassesAmount", 0);
            PlayerPrefs.SetInt("ribbonAmount", 0);
            PlayerPrefs.SetInt("boneAmount", 0);
            PlayerPrefs.SetInt("ballAmount", 0);

            


            PlayerPrefs.SetInt("switch",1);  
            PlayerPrefs.SetInt("MoneySwitch",0); 

            // GameObject.Find("UISliderController").AddComponent<MoneyManager>().Start(); 
            
        //} 
        //PlayerPrefs.SetInt("switch",0); 
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ExpNumController : MonoBehaviour
{
    public Image image; 
    public float expVal;
    public float levelVal;
    public MoneyManager MoneyManager;

    
    [SerializeField] private TextMeshProUGUI levelText = null;
    [SerializeField] private TextMeshProUGUI expText = null;
    [SerializeField] private float maxExpAmount = 200.0f;


    void Start()
    {
        image.fillAmount = PlayerPrefs.GetFloat("expVal", 0);
        expText.text = (PlayerPrefs.GetFloat("expVal", 0) * maxExpAmount).ToString("0");
        levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("switch", 0) == 1)
        {
            levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
            image.fillAmount = PlayerPrefs.GetFloat("expVal", 0);
            PlayerPrefs.SetInt("HungryRef", 1); //true
            PlayerPrefs.SetInt("CleanRef", 1); //true
            PlayerPrefs.SetInt("SleepRef", 1); //true
            PlayerPrefs.SetInt("switch", 0);
        }
        else
        {

            if (PlayerPrefs.GetFloat("HungryBar", 0) >= 1.0f && PlayerPrefs.GetInt("HungryRef", 0) == 1) 
            {
                image.fillAmount += 0.3f;
                PlayerPrefs.SetInt("HungryRef", 0); //true
            } else if (PlayerPrefs.GetFloat("HungryBar", 0) < 1.0f) {
                PlayerPrefs.SetInt("HungryRef", 1); 
            }

            if (PlayerPrefs.GetFloat("CleanBar", 0) >= 1.0f && PlayerPrefs.GetInt("CleanRef", 0) == 1) 
            {
                image.fillAmount += 0.3f;
                PlayerPrefs.SetInt("CleanRef", 0); //true
            } else if (PlayerPrefs.GetFloat("CleanBar", 0) < 1.0f) {
                PlayerPrefs.SetInt("CleanRef", 1); 
            }

            if (PlayerPrefs.GetFloat("SleepBar", 0) >= 1.0f && PlayerPrefs.GetInt("SleepRef", 0) == 1) 
            {
                image.fillAmount += 0.3f;
                PlayerPrefs.SetInt("SleepRef", 0); //true
            } else if (PlayerPrefs.GetFloat("SleepBar", 0) < 1.0f) {
                PlayerPrefs.SetInt("SleepRef", 1); 
            }

            if (image.fillAmount >= 0.99f)
            {
                PlayerPrefs.SetFloat("levelVal", PlayerPrefs.GetFloat("levelVal", 0) + 1.0f);
                levelText.text = PlayerPrefs.GetFloat("levelVal", 0).ToString();
                image.fillAmount = 0.0f;
                MoneyManager.addMoney(20000);
            }
            PlayerPrefs.SetFloat("expVal", image.fillAmount);
        }
        expText.text = (PlayerPrefs.GetFloat("expVal", 0) * maxExpAmount).ToString("0");
    }


}

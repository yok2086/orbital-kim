using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager : MonoBehaviour
{
    public static TimeManager timeManager;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("SleepBar", 0f);
        PlayerPrefs.SetFloat("CleanBar", 0f);
        PlayerPrefs.SetFloat("HungryBar", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        string time = PlayerPrefs.GetString("time");
        if (!string.IsNullOrEmpty(time))
        {
            DateTime dateTime = Convert.ToDateTime(time);
            DateTime now = DateTime.Now;
            if (dateTime.AddMinutes(1) < now)
            {
                float sleepBar = PlayerPrefs.GetFloat("SleepBar");
                if (sleepBar >= 0.1f)
                {
                    PlayerPrefs.SetFloat("SleepBar", sleepBar - 0.1f);
                }

                else
                {
                    PlayerPrefs.SetFloat("SleepBar", 0f);
                }
                float cleanBar = PlayerPrefs.GetFloat("CleanBar");
                if (cleanBar >= 0.1f)
                {
                    PlayerPrefs.SetFloat("CleanBar", cleanBar - 0.1f);
                }

                else
                {
                    PlayerPrefs.SetFloat("CleanBar", 0f);
                }
                float hungryBar = PlayerPrefs.GetFloat("HungryBar");
                if (hungryBar >= 0.1f)
                {
                    PlayerPrefs.SetFloat("HungryBar", hungryBar - 0.1f);
                }

                else
                {
                    PlayerPrefs.SetFloat("HungryBar", 0f);
                }
                PlayerPrefs.SetString("time", now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
        else
        {
            PlayerPrefs.SetString("time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
        

    }

    void Awake()
    {
        if (timeManager == null)
        {
            timeManager = this;
            DontDestroyOnLoad(gameObject);

        }
        else if (timeManager != this)
        {
            Destroy(gameObject); 
        }
    }
}

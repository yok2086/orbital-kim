using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LuckyDrawManager : MonoBehaviour
{
    public Button luckyDrawButton;
    public MoneyManager moneyManager;
    public GameObject spinWheel;
    public GameObject black;
    public Button homeButton;
    public TextMeshProUGUI timerText;

    private bool isSpinning = false;
    private float speed = 10.0f;
    private float angle = 0f;
    private int[] moneyArray = { 100, 500, 1000, 1500, 3000, 5000 };
    private bool isTimerRunning = false;
    private float time = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        timerText.gameObject.SetActive(false);
        checkTime();
    }

 

     public void Spin()
    {

        speed = UnityEngine.Random.Range(10.0f, 15.0f);
        isSpinning = true;
        setLuckyDrawButton(false);
        homeButton.interactable = false;
    }

   
    // Update is called once per frame
    void FixedUpdate()
    {
        if (isSpinning)
        {
            if (speed <= 0.05f)
            {
                isSpinning = false;
                moneyManager.addMoney(moneyArray[(int)angle / 60 % 6]);
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                PlayerPrefs.SetString("luckyDrawTime", now);
                homeButton.interactable = true;
            }
            spinWheel.transform.Rotate(0, 0, speed);
            speed *= 0.99f;
            angle = spinWheel.transform.eulerAngles.z;
        }


    }

    void Update()
    {
        checkTime();
    }

    private void checkTime()
    {
        string time = PlayerPrefs.GetString("luckyDrawTime");
        if (!string.IsNullOrEmpty(time))
        {
            DateTime saveTime = Convert.ToDateTime(time);
            DateTime now = DateTime.Now;
            if (saveTime.AddMinutes(10) > now)
            {
                timerText.gameObject.SetActive(true);
                timerText.text = (saveTime.AddMinutes(10) - now).ToString(@"mm\:ss");
                setLuckyDrawButton(true);

            }

            else
            {
                timerText.gameObject.SetActive(false);
                PlayerPrefs.SetString("luckyDrawTime", null);
                setLuckyDrawButton(true);


            }

        }

    }

    private void setLuckyDrawButton(bool signal)
    {
        luckyDrawButton.interactable = signal;
        black.SetActive(!signal);

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SleepingManager : MonoBehaviour
{
    public HPUI hpUI;
    public GameObject black;
    public TextMeshProUGUI timerText;
    public Button homeButton;
    public Button pillow;
    public Button bed;
    public Button water;

    private bool isTimerRunning = false;
    private float time;
    private float barGauge;
    // Start is called before the first frame update
    void Start()
    {
        black.SetActive(false);
        timerText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void SetButtonInteractable(bool signal)
    {
        pillow.interactable = signal;
        bed.interactable = signal;
        water.interactable = signal;
        homeButton.interactable = signal;

    }

    private void UpdateTimerText()
    {
        timerText.text = time.ToString("F1");
    }


    private float GetTimeByButton(Button button)
    {
        if (button == pillow)
        {
            return 5.0f;
        }
        else if (button == bed)
        {
            return 10.0f;
        }
        else if (button == water)
        {
            return 3.0f;
        }
        else
        {
            return 0f;
        }
    }

    public void Sleep(Button button)
    {
        StartTimer(button);
    }

    private void StartTimer(Button button)
    {
        SetButtonInteractable(false);
        time = GetTimeByButton(button);
        SetBarGauge(button);

        isTimerRunning = true;
        timerText.gameObject.SetActive(true);
        black.SetActive(true);
    }
    private void SetBarGauge(Button button)
    {
        if (button == pillow)
        {
            barGauge = 0.2f;
        }

        else if (button == bed)
        {
            barGauge = 0.4f;
        }

        else if (button == water)
        {
            barGauge = 0.1f;
        }
        else
        {
            barGauge = 0f;
        }

    }

    void Update()
    {
        if (isTimerRunning)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                UpdateTimerText();
            }
            else
            {
                SetButtonInteractable(true);
                isTimerRunning = false;
                timerText.gameObject.SetActive(false);
                black.SetActive(false);
                hpUI.AddBarGauge(barGauge);

            }

        }
    }
}

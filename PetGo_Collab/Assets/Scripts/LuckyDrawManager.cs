using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckyDrawManager : MonoBehaviour
{
    public Button luckyDrawButton;
    public MoneyManager moneyManager;
    public GameObject spinWheel;
    public GameObject black;
    public Button homeButton;

    private bool isSpinning = false;
    private float speed = 10.0f;
    private float angle = 0f;
    private int[] moneyArray = { 100, 500, 1000, 1500, 3000, 5000 };
    // Start is called before the first frame update
    void Start()
    {
        black.SetActive(false);
    }

    public void SetButtonInteractable(bool signal)
    {
        homeButton.interactable = signal;
        luckyDrawButton.interactable = signal;

    }


    public void Spin()
    {
        speed = 10.0f;
        isSpinning = true;
        SetButtonInteractable(false);
        black.SetActive(true);
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
            }
            spinWheel.transform.Rotate(0, 0, speed);
            speed *= 0.99f;
            angle = spinWheel.transform.eulerAngles.z;
        }

        else
        {
            SetButtonInteractable(true);
            black.SetActive(false);
        }
    }
}
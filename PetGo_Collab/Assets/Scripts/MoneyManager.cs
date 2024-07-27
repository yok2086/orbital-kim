using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public int initialMoney;
    public TextMeshProUGUI moneyText;
    private int Money;
    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerPrefs.GetInt("Money", initialMoney);
        if (PlayerPrefs.GetInt("MoneySwitch", 0) == 0) 
        {
            initialMoney = 20000; 
            PlayerPrefs.SetInt("Money", initialMoney);
            Money = PlayerPrefs.GetInt("Money", initialMoney); 
            moneyText.text = Money.ToString();
            PlayerPrefs.SetInt("MoneySwitch", 1) ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("MoneySwitch", 0) == 0) {
            Money = 20000; 
        }  
        PlayerPrefs.SetInt("Money", Money);
        moneyText.text = Money.ToString();
    }

    public int getMoney()
    {
        return Money;
    }

    public void addMoney(int amount)
    {
        Money += amount;

    }

    public bool minusMoney(int amount)
    {
        if (Money - amount >= 0)
        {
            Money -= amount;
            return true;
        }
        else
        {
            return false;

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public int Money;
    public TextMeshProUGUI moneyText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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

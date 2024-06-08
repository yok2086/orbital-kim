using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPUI : MonoBehaviour
{
    public Image filledBar;

    public Gradient gradient;

    public int minHP;
    public int maxHP;
    private int currentHP;
    void Start()
    {
        currentHP = maxHP / 2;
        UpdateUI();
    }

    public void Eat(int points)
    {
        currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        UpdateUi();
    }

    // Update is called once per frame
    void UpdateUI()
    {
        filledBar.fillamount = currentHP / maxHP;
        filledBar.color = gradient.Evaluate(filledBar.fillAmount);
    }
}

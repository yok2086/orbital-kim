using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUI : MonoBehaviour
{
    public Image filledBar;

    public Gradient gradient;

    public float minHP = 0f;
    public float currentHP = 0f;
    public float maxHP = 1f;
    public float points = 0.1f;
    void Start()
    {
        currentHP = minHP;
        filledBar.fillAmount = currentHP;
        
    }

    public void Eat()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += points;
    }

    public void Clean()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += points;
    }

    public void Sleep()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += 0.3f;
    }

    public void Nap()
    {
        //currentHp = Mathf.Clamp(currentHP + points, minHp, maxHP);
        currentHP += points;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButton(0))
        //{
            filledBar.fillAmount = currentHP;
        //Debug.Log("space key pressed");
        //}
        //filledBar.fillamount = currentHP / maxHP;
        filledBar.color = gradient.Evaluate(filledBar.fillAmount);
    } 
}

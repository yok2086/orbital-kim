using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    //GameObject cleanBar;
    // Start is called before the first frame update
    public int maxValue = 5;
    public int currentValue;
    public ExpBar xpBar;
    public XpNum xpNum;  
    void Start()
    {
        //this.cleanBar = GameObject.Find("cleanBar");
        //this.xpBar = GameObject.Find("Canvas").GetComponentInChildren<XpBar>();
        Debug.Log("hello");
        Debug.Log(xpBar);
        xpBar.SetMaxVaue(maxValue);
        currentValue = 0;
        xpBar.SetValue(currentValue);

    }

    // public void IncCleanBar()
    // {
    //     this.cleanBar.GetComponent<Image>().fillAmount += 0.001f;
    // }


    // public void DecCleanBar()
    // {
    //     this.cleanBar.GetComponent<Image>().fillAmount -= 0.001f;
    // }

    // public float GetAmount()
    // {
    //     return this.cleanBar.GetComponent<Image>().fillAmount;
    // }


    // Update is called once per frame
    void Update()
    {
        currentValue = xpBar.GetCurrentValue();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentValue < maxValue)
            {

                xpBar.SetValue(currentValue + 1);
                //xpBar.SetValue(4);

                Debug.Log(xpBar.GetCurrentValue());

            }
            else
            {
                xpBar.SetValue(0);
            }
        }
        if (currentValue == maxValue){
            xpNum.AddLevel();
            Debug.Log(xpNum.GetLevel());
            xpBar.SetValue(0);
        }
        //StartCoroutine(BarDelay());
        //IncCleanBar();

        // GameObject director = GameObject.Find("Game Director");
        // director.GetComponent<GameDirector>().DecCleanBar();
    }

    // private IEnumerator BarDelay()
    // {
    //     yield return new WaitForSeconds(100);
    // }
}

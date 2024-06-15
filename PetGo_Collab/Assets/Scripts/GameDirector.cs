using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject cleanBar;
    // Start is called before the first frame update
    void Start()
    {
        this.cleanBar = GameObject.Find("cleanBar");
    }

    public void IncCleanBar()
    {
        this.cleanBar.GetComponent<Image>().fillAmount += 0.001f;
    }


    public void DecCleanBar()
    {
        this.cleanBar.GetComponent<Image>().fillAmount -= 0.001f;
    }

    public float GetAmount() 
    {
        return this.cleanBar.GetComponent<Image>().fillAmount;
    }


    // Update is called once per frame
    void Update()
    {
        StartCoroutine(BarDelay());
        DecCleanBar();
        // GameObject director = GameObject.Find("Game Director");
        // director.GetComponent<GameDirector>().DecCleanBar();
    }

    private IEnumerator BarDelay()
    {
        yield return new WaitForSeconds(100);
    }
}

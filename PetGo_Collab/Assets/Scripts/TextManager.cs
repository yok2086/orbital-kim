using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI moneyNotEnoughText;
    // Start is called before the first frame update
    void Start()
    {
        moneyNotEnoughText.gameObject.SetActive(false);
    }

    public IEnumerator  ShowTextForSeconds( int seconds)
    {
        moneyNotEnoughText.gameObject.SetActive(true);
        yield return new WaitForSeconds(seconds);
        moneyNotEnoughText.gameObject.SetActive(false);
    }

    public void DisplayTextForSeconds( int seconds)
    {
        StartCoroutine(ShowTextForSeconds(seconds));

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Walking; 
    void Start()
    {
        
    }

    public void BlackClicked() 
    {
        Walking.SetTrigger("Black"); 
    }

    // Update is called once per frame
    void Update()
    {
        // if (PlayerPrefs.GetInt("blackAmount") >= 1) {
        //     Walking.SetTrigger("Black"); 
        // }

        Debug.Log(PlayerPrefs.GetInt("blackAmount")); 
    }
}

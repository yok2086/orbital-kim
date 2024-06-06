using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToiletToMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("start!!!");
    }
    public void HomeButton() 
    {
        SceneManager.LoadScene(0);
        //Debug.Log("Home button");
    }

    // public void ToiletButton() {
    //     SceneManager.LoadScene("Toilet");
    // }
    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     ToiletButton();
        // } 
        
    }
}

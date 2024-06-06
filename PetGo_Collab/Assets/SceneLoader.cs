using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; 
    }

    public void HomeButton() 
    {
        SceneManager.LoadScene("Main scene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

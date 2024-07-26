using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public Animator StateController; 
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("SleepBar") < 0.5f)
        {
            StateController.SetTrigger("Tired"); 
        }
        if (PlayerPrefs.GetFloat("HungryBar") < 0.5f)
        {
            StateController.SetTrigger("Hungry"); 
            Debug.Log("HungryBar < 0.5");
        }
        if (PlayerPrefs.GetFloat("CleanBar") < 0.5f)
        {
            StateController.SetTrigger("Dirty"); 
        }
        Debug.Log(PlayerPrefs.GetFloat("HungryBar"));
    }
}

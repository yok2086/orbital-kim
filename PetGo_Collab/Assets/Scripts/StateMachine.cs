using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public Animator TiredAnim; 
    public Animator HungryAnim; 
    public Animator DirtyAnim; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("SleepBar") < 0.5f)
        {
            TiredAnim. SetTrigger("Tired"); 
        }
        if (PlayerPrefs.GetFloat("HungryBar") < 0.5f)
        {
            HungryAnim. SetTrigger("Hungry"); 
        }
        if (PlayerPrefs.GetFloat("CleanBar") < 0.5f)
        {
            DirtyAnim. SetTrigger("Dirty"); 
        }
        Debug.Log(PlayerPrefs.GetFloat("HungryBar"));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingManager : MonoBehaviour
{
    public HPUI hpUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Sleep()
    {

        hpUI.AddBarGauge();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckyDrawManager : MonoBehaviour
{
    public Button luckyDrawButton;
    public GameObject spinWheel;
    private bool isSpinning = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Spin()
    {
        isSpinning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpinning)
        {
            spinWheel.transform.Rotate(0, 0, 10.0f);
        }
    }
}
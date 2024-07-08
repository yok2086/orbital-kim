using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckyDrawManager : MonoBehaviour
{
    public Button luckyDrawButton;
    public GameObject spinWheel;
    private bool isSpinning = false;
    private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Spin()
    {
        speed = 10.0f;
        isSpinning = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isSpinning)
        {
            if (speed <= 0.0f)
            {
                isSpinning = false;
            }
            spinWheel.transform.Rotate(0, 0, speed);
            speed *= 0.99f;
        }
    }
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;
//using System;
//public class Timer : MonoBehaviour
//{
//    [SerializeField] TextMeshProUGUI timerText;
//    [SerializeField] float remainingTime;


//    // Update is called once per frame
//    void Update()
//    {
//        remainingTime -= Time.deltaTime;
//        int minutes = Mathf.FloortoInt(remainingTime / 60);
//        int seconds = Mathf.FloortoInt(remainingTime % 60);
//        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
//    }
//}

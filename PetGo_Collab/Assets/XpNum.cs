using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class XpNum : MonoBehaviour
{
    public int level;
    public Text xpNum; 
    public Text GetLevel() {
        return xpNum; 
    }    
    public void SetLevel(int level) {
        xpNum.text = level.ToString(); 
    }
    public void AddLevel() {
        int num = 0;
        num = int.Parse(xpNum.text); 
        num += 1;
        SetLevel(num);
    }


}

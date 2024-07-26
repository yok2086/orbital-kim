using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator DogAnim;
    public InventoryManager InventoryManager;
    
    void Start()
    {

    }

    public void BlackClicked()
    {
        InventoryManager.useItem(6);
        if ((PlayerPrefs.GetInt("blackAmount",0) >= 1)) 
        {
            DogAnim.SetTrigger("BlackClothes");
        } 
    }
    public void PinkClicked()
    {
        InventoryManager.useItem(7);
        if (PlayerPrefs.GetInt("pinkAmount",0) >= 1) 
        {
            DogAnim.SetTrigger("PinkClothes");
        }
        
    }

    public void RedClicked()
    {
        InventoryManager.useItem(8);
        if (PlayerPrefs.GetInt("redAmount",0) >= 1) 
        {
            DogAnim.SetTrigger("RedClothes");
        }
    }

    public void YellowClicked()
    {
        InventoryManager.useItem(9);
        if (PlayerPrefs.GetInt("yellowAmount",0) >= 1) 
        {
            DogAnim.SetTrigger("YellowClothes");
        }
    }

    public void BlueClicked()
    {
        InventoryManager.useItem(10);
        if (PlayerPrefs.GetInt("blueAmount",0) >= 1) {
            DogAnim.SetTrigger("BlueClothes");
        }
        
    }
    public void SunglassesClicked()
    {
        InventoryManager.useItem(11);
        if (PlayerPrefs.GetInt("sunglassesAmount",0) >= 1) {
            DogAnim.SetTrigger("Sunglasses");
        }
    }

    public void RibbonClicked()
    { 
        InventoryManager.useItem(12);
        if (PlayerPrefs.GetInt("ribbonAmount",0) >= 1) {
            DogAnim.SetTrigger("Ribbon");
        }
    }


    public void BoneClicked()
    {
        InventoryManager.useItem(13);
        if (PlayerPrefs.GetInt("boneAmount",0) >= 1) {
            DogAnim.SetTrigger("Bone");
        }
    }
    public void BallClicked()
    {
        InventoryManager.useItem(14);
        if (PlayerPrefs.GetInt("ballAmount",0) >= 1) {
            DogAnim.SetTrigger("Ball");
        }
    }



    // Update is called once per frame
    void Update()
    {
        // if (PlayerPrefs.GetInt("blackAmount") >= 1) {
        //     Walking.SetTrigger("Black"); 
        // }

        //Debug.Log(PlayerPrefs.GetInt("blackAmount")); 
    }
}

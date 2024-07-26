using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator DogAnim;
    void Start()
    {

    }

    public void BlackClicked()
    {
        DogAnim.SetTrigger("BlackClothes");
    }
    public void PinkClicked()
    {
        DogAnim.SetTrigger("PinkClothes");
    }

    public void RedClicked()
    {
        DogAnim.SetTrigger("RedClothes");
    }

    public void YellowClicked()
    {
        DogAnim.SetTrigger("YellowClothes");
    }

    public void BlueClicked()
    {
        DogAnim.SetTrigger("BlueClothes");
    }

    public void RibbonClicked()
    {
        DogAnim.SetTrigger("Ribbon");
    }

    public void SunglassesClicked()
    {
        DogAnim.SetTrigger("Sunglasses");
    }

    public void BoneClicked()
    {
        DogAnim.SetTrigger("Bone");
    }
    public void BallClicked()
    {
        DogAnim.SetTrigger("Ball");
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

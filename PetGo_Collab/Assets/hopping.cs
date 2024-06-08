using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Subsystems;
//using UnityEngine.UI;

public class hopping : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Transform transform;
    float jumpforce = 20.0f;
   
    //Image cleanBarImage;
    public void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();

        this.transform = GetComponent<Transform>();
        // GameObject cleanBar = GameObject.Find("cleanBar");
        //cleanBarImage = cleanBar.GetComponent<Image>();
        // Debug.Log(cleanBarImage);

    }



    public void Update()
    {
        
        // GameObject gameDirector = GameObject.Find("Game Director");
        // float width = gameDirector.GetComponent<GameDirector>().GetAmount();
  
        // if (width == 0f) {
        //     jumpforce = 0f;
        // }
        // if (this.transform.position.y <= -2.5f)
        // {
        //     //Debug.Log("here_2");
        //     this.rigid2D.AddForce(transform.up * this.jumpforce);
        // }

    }

    // IEnumerator Wait()
    // {
    //     print(Time.time);
    //     yield return new WaitForSeconds(5);
    //     print(Time.time);
    // }


}

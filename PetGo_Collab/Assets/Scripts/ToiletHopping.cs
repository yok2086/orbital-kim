using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using UnityEngine.Subsystems;


public class ToiletHopping : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Transform transform1;
    float jumpforce = 200.0f;

    public void Jump()
    {

        this.rigid2D = GetComponent<Rigidbody2D>();
        this.transform1 = GetComponent<Transform>();

        Debug.Log("toilethopping");


        if (this.transform1.position.y <= 0f)
        {
            this.rigid2D.AddForce(transform.up * this.jumpforce);
        }
    }

}


using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Subsystems;
//using UnityEngine.UI;

public class Hopping : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Transform transform;
    float jumpforce = 20.0f;

    public void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.transform = GetComponent<Transform>();
    }


    public void Update()
    {
        if (this.transform.position.y <= -2.5f)
        {
            this.rigid2D.AddForce(transform.up * this.jumpforce);
        }
    }

}

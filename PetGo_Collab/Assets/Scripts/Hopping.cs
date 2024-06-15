using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Subsystems;

public class Hopping : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Transform transform1;
    float jumpforce = 20.0f;

    public void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.transform1 = GetComponent<Transform>();
    }

    public void Update()
    {
        if (this.transform1.position.y <= -2.5f)
        {
            this.rigid2D.AddForce(transform.up * this.jumpforce);
        }
    }

}

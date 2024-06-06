using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using UnityEngine.Subsystems;


public class toiletHopping : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Transform transform;
    float jumpforce = 200.0f;

    public void ToiletHopping()
    {
        // Rigidbody2D rigid2D;
        // Transform transform;
        // float jumpforce = 20.0f;
        // public float X = 0f;
        // public float Y = -3f;
        //public float Z = 0f;
        Debug.Log("toilethopping ");
        GameObject dog = GameObject.Find("dog");

        if (dog.transform.position.y <= 0f)
        {
            dog.GetComponent<toiletHopping>().Update_toilet();

            Debug.Log("toilethopping 2");

            // dog.rigid2D.AddForce(transform.up * this.jumpforce);
            // dog.GetComponent.rigid2D.AddForce(transform.up * this.jumpforce);

        }
    }

    public void Update_toilet()
    {
        //this.transform.position = new Vector3(X,Y,Z);
        Debug.Log(this);
        // Debug.Log("here");
        //if (this.transform.position.y <= -2.5f)
        //{
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.transform = GetComponent<Transform>();
        Debug.Log("here_2");
        this.rigid2D.AddForce(transform.up * this.jumpforce);
        //Debug.Log("here");
        //}

    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

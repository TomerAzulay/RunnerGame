using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float forwardSpeed=1000 ;
    public float sideSpeed = 500;
    Rigidbody rb;
    
    void Start()
    {
        //Making connection between the "rb" variable and rigidbody component of the object
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //fixed update is better for physichs
    private void FixedUpdate()
    {
        //rb is connect to the rigidbody of the gameobject and we add force only to the "z" axis to make it move forward ./ Time.deltatime for making it perform on every frame rate the same .
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        //adding force on the "x" axis when a key is on hold.
        if (Input.GetKey("a"))
        {//- is for making it move left.
            rb.AddForce(-sideSpeed*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControlller : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public float minSpeed;
    public float rotSpeed1;
    public float rotSpeed2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.position += transform.forward * Time.deltaTime * speed ;


        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxSpeed) speed++;
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (speed> minSpeed) speed--;

        }


        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward*Time.deltaTime * rotSpeed1);
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * rotSpeed1);
        }

        if(Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotSpeed1);
        }

        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotSpeed1);
        }



        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * rotSpeed2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down * Time.deltaTime * rotSpeed2);
        }

        //gravity

        speed -= transform.forward.y * Time.deltaTime * 50;
        if (speed < minSpeed / 2) speed = minSpeed;
        if(speed > maxSpeed * 2) speed = maxSpeed;


        
    }

   

}

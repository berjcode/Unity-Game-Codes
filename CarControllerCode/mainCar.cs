using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    
    public float verticalSpeed, horizontalSpeed, defaultSpeed;
    private float verticalMovement, horizontalMovement;

    //Audio


    Rigidbody2D rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();// Oyun baþladýðýnda obje ile deðiþkeni eþitler.

    }


    private void FixedUpdate()
    {
         #region Movement 
            verticalMovement = SimpleInput.GetAxis("Vertical"); //Diket Hareket
            horizontalMovement = SimpleInput.GetAxis("Horizontal");//YtayHareket



            rb.velocity = new Vector3
                (horizontalMovement * 50 * horizontalSpeed * Time.deltaTime, defaultSpeed + verticalMovement * 50 * verticalSpeed * Time.deltaTime);
            #endregion

        





        #region Right-Left Contact Control 
        if (transform.position.x > 1.44f)
        {
            Vector3 rightLimit = new Vector3(1.44f, transform.position.y);
            transform.position = rightLimit;
        }
        if (transform.position.x < -1.38f)
        {
            Vector3 leftLimit = new Vector3(-1.38f, transform.position.y);
            transform.position = leftLimit;
        }

        #endregion


    }

    

}

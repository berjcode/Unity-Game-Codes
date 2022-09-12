using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CarNPC : MonoBehaviour
{
    private ScoreManager manager;
    private float defaultSpeed;
    private int stripe;
    Rigidbody2D rb;
    public int carSprite;
    
    public Sprite car1, car2, car3, car4, car5, car6, car7;
    SpriteRenderer spr;
    void Start()
    {
        manager= GameObject.FindObjectOfType<ScoreManager>();   
        rb = GetComponent<Rigidbody2D>();
        stripe = Random.Range(1, 5);
        defaultSpeed = Random.Range(2.5f, 3.5f);
        carSprite = Random.Range(1, 12);
        spr = GetComponent<SpriteRenderer>();
        #region StripeControl
        if (stripe==1)
        {
            transform.position = new Vector3(-1.454f, transform.position.y + 10, 0);

        }else if(stripe==2)
        {
            transform.position = new Vector3(-0.504f, transform.position.y + 10, 0);
        }
        else if(stripe==3)
        {
            transform.position = new Vector3(0.51f, transform.position.y + 10, 0);
        }
        else
        {
            transform.position = new Vector3(1.49f, transform.position.y + 10, 0);
        }
        #endregion

        #region Switch Case
        switch(carSprite)
        {
            case 1:
                spr.sprite = car1;
                break;
            case 2:
                spr.sprite = car2;
                break;

            case 3:
                spr.sprite = car3;
                break;
            case 4:
                spr.sprite = car4;
                break;
            case 5:
                spr.sprite = car5;
                break;
            case 6:
                spr.sprite = car6;
                break;
            case 7:
                spr.sprite = car7;
                break;
        }

        #endregion
    }



    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x,defaultSpeed*50*Time.deltaTime,0);
    }


    private void OnCollisionEnter2D(Collision2D contact)
    {
        
        if(contact.gameObject.tag=="MainCar")
        {
            SceneManager.LoadScene(2);
            ScoreManager.score = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="OverTaking")
        {
            ScoreManager.score += 20;
           
        }
    }
}

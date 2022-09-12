using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
      float Horizontal;
    public Rigidbody2D playerRig;


    private void Start()
    {
        if(instance == null)
        {
           instance = this;
        }
    }
    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Horizontal = Input.acceleration.x;

        }

        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        playerRig.velocity = new Vector2(Input.acceleration.x * 10f, playerRig.velocity.y);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            SceneManager.LoadScene(0);
        }
    }
}

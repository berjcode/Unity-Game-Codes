using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public static Enemy Instance { get; private set; }
    public void Awake()
    {
        Instance = this;
    }
    // ScoreManager scoreManager;
    public int health =50;
    

   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "EnemySpawner" )
        {
            
                float xPos = Random.Range(-2.5f, 2.5f);
                float ypos = Random.Range(-4f, 4);
                transform.position = new Vector2(xPos, ypos);
               

                health-=10;
            ScoreManager.instance.healtText.text = "Health "+health.ToString();
         }
        

            if (collision.gameObject.name == "Player")
            {

              

            float xPos = Random.Range(-2.5f, 2.5f);
            float ypos = Random.Range(-4f, 4);
            transform.position = new Vector2(xPos, ypos);
            health++;
            ScoreManager.instance.healtText.text = "Health "+health.ToString();



        }



        

        
        






    }
}

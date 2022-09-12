using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float rotateSpeed = 90;
    public float speed = 5f;
    public float fireInterval =0.5f;
    public float bulletSpeed=20;
    public Transform spawnPoint;
    public GameObject bulletPrefabs;
    float nextFire;

    void Start()
    {
      nextFire = Time.time+fireInterval;
    }

    // Update is called once per frame
    void Update()
    {
      var transAmount = speed* Time.deltaTime;
      var rotateAmount = rotateSpeed*Time.deltaTime;

      if(Input.GetKey("up"))
      {
        transform.Translate(0,0,transAmount);

      }

      if(Input.GetKey("down"))
      {
        transform.Translate(0,0,-transAmount);
      }
       
       if(Input.GetKey("left"))
       {
        transform.Rotate(0,-rotateAmount,0);
       }
       if(Input.GetKey("right"))
       {
        transform.Rotate(0,rotateAmount,0);
       }

       if(Input.GetButtonDown("Fire1")&& Time.time > nextFire)
       {
        nextFire = Time.time + fireInterval;
        fire();
       }



    }

  void fire()
  {
    var bullet = Instantiate(bulletPrefabs,spawnPoint.position,spawnPoint.rotation);
    bullet.GetComponent<Rigidbody>().velocity  = transform.forward * bulletSpeed;
  }
   
}


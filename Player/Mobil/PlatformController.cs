using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float forceJump;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y<0)
        {
            PlayerController.instance.playerRig.velocity = Vector2.up * forceJump;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.name =="DeadZone")
        {
            float RandX = Random.Range(-1.7f, 1.7f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            transform.position = new Vector3(RandX, RandY,0);
        }
    }
}

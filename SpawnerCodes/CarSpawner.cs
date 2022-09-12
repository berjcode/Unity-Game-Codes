using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject randomCarNpc;
    bool canSpawn = true;
    void Start()
    {
        StartCoroutine(wait());
    }

  
    void Update()
    {
        
    }

    IEnumerator wait()
    {
        while(canSpawn == true)
        {
            Instantiate(randomCarNpc, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);

        }

    }
}

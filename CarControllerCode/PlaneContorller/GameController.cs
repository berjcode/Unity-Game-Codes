using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("XXX");
        canvas.enabled = true;

    }


    public void restart()
    {
        canvas.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        
    }
}

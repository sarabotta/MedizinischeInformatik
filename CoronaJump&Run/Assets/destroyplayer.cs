using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyplayer : MonoBehaviour
{
    //public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("Trigger!");
        SceneManager.LoadScene("GameOver");
       
    }
}

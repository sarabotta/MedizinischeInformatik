using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplayer2 : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "Enemy") ;
        { 
            gameObject.SetActive(false); 
        
        }
       
       
    }
}

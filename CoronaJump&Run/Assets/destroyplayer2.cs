using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplayer2 : MonoBehaviour
{
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

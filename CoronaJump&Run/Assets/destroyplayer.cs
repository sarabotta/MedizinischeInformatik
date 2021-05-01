using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        //if(other.gameObject.tag == "Player")
        //{
           // GameObject e = Instantiate(explosion) as GameObject;
            //e.transform.position = transform.position;
           // Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
        //}
    }
}

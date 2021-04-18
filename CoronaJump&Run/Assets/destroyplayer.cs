using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplayer : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject e = Instantiate(explosion) as GameObject;
            Destroy(gameObject);
            this.gameObject.SetActive(false);
        }
    }
}

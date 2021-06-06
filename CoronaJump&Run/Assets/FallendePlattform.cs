using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallendePlattform : MonoBehaviour
{
    private Rigidbody2D rb2d_Platform;

    // Start is called before the first frame update
    void Start()
    {
        rb2d_Platform = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            // Platforn nach unten fallen
            rb2d_Platform.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}

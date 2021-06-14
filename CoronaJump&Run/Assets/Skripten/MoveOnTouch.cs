using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    private Vector3 velocity;
    private bool moving;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        { 
            moving = true;
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(null);
        }
    }

    private void FixedUpdate()
    {
        if (moving)
        {
            transform.position += (velocity * Time.deltaTime);
        }
    }


}

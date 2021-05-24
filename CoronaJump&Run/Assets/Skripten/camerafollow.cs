using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
   private Transform playerTransform;
   public float offset;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update() {
       


    }
    void FixedUpdate()
    {

    }
    void LateUpdate()
    {
        //current camera's position in variable temp
        Vector3 temp = transform.position;
        //camera position x,y = player position x,y,z
        temp.x = playerTransform.position.x;
        temp.x += offset;
        temp.y = playerTransform.position.y;
        temp.z = playerTransform.position.z;
        //set back camera's temp position to the camera's current position
        playerTransform.position = temp;


    }
} 

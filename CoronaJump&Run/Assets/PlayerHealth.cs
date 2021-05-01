using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Slider slider;
    public Text text;
    float dist = Vector3.Distance(objA.tansform.position, objB.transform.position);
    float radius = objA.radius + objB.radius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        text.text = "verbleibende Leben: " + health;
    }

    void OnCollisionEnter2D(Collision2D player)
    {
        if (dist < radius)
            health = health - 1;
    }
}

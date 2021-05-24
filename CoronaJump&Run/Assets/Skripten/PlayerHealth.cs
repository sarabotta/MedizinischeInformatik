using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Corona")
        {
            this.GetComponent<HealthBar>().slider.maxValue -= 1;
        }
    }
}
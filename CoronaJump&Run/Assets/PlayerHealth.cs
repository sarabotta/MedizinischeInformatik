using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        text.text = "verbleibende Leben: " + health;
    }

    void OnTriggerEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Corona")
            health = health - 1;
    }
}

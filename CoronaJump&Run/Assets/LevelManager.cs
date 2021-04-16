using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;
    public GameObject spieler;
    public int leben;
    public Text lebenText;

    // Start is called before the first frame update
    void Start()
    {
        lebenText.text = "Leben:" + leben.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Spiel wird beendet");
            Application.Quit();
        }
    }

    public void RespawnPlayer()
    {
        leben = leben - 1;
        lebenText.text = "Leben:" + leben.ToString();
        if (leben > 0)
        {
            spieler.transform.position = currentCheckpoint.transform.position;
        }
        else
        {
            Time.timeScale = 0.0f;
            Debug.Log("Die Quarantäne erwartet dich!");
        }

    }
}

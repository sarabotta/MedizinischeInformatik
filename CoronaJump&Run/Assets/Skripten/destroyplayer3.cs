using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyplayer3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Trigger!");
            SceneManager.LoadScene("GameOver3");
        }
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene("LevelFinish");
        }
    }
}

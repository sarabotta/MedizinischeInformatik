using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    
    public void Setup(int score)
    {
        gameObject.SetActive(true);

    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SpielPROBE");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Hauptmenü");
    }
}

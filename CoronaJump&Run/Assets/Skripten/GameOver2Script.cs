using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2Script : MonoBehaviour
{
    public void RestartButton()
    {

        SceneManager.LoadScene("Level2");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Hauptmenü");
    }
}

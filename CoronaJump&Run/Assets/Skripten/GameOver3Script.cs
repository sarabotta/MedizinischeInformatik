using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver3Script : MonoBehaviour
{
    public void RestartButton()
    {

        SceneManager.LoadScene("Level3");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Hauptmenü");
    }
}

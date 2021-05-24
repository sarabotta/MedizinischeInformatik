using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startbutton()
    {
        SceneManager.LoadScene("SpielPROBE");
    }
    public void levelsbutton()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void exitbutton()
    {
        Application.Quit();
    }
}

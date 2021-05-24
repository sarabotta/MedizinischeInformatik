using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
   public void Level1Button()
    {
        SceneManager.LoadScene("SpielPROBE");
    }
    public void Level2Button()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3Button()
    {
        SceneManager.LoadScene("Level3");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Hauptmenü");
    }
}

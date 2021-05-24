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
        
    }
    public void Level3Button()
    {

    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Hauptmenü");
    }
}

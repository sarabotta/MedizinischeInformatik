using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish1 : MonoBehaviour
{
    public void selectlevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void nextlevel()
    {
        SceneManager.LoadScene("Level2");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Hauptmenü");
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public void selectlevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void nextlevel()
    {
        //SceneManager.LoadScene("");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Hauptmenü");
    }
}

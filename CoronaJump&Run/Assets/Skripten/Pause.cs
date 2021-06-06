using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
   [SerializeField] GameObject pauseMenu;

   public void pausieren()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Hauptmen�");
    }
}

using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;
    public static bool isPaused = false;

    private void Start()
    {
        Menu.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }
    
    public void pauseGame()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resumeGame()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        isPaused=false; 
    }
    
    public void loadMainMenu()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        isPaused=false; 
    }
}

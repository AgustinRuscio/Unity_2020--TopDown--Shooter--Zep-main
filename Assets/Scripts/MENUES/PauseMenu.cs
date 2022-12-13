//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool  isGamePuased = false;

    public GameObject   pauseMenuUI;
    public GameObject   blackPanel;

    public AudioSource backgroundMusic;
    public AudioSource pausedMusic;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePuased)  
                Resume();        
            else
                Pause();           
        }    
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        blackPanel.SetActive(false);

        pausedMusic.Stop();
        backgroundMusic.Play();

        Time.timeScale = 1f;
        isGamePuased = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        blackPanel.SetActive(true);

        backgroundMusic.Pause();
        pausedMusic.Play();

        Time.timeScale = 0f;
        isGamePuased = true;
    }

    public void mainMenu()
    {
        pauseMenuUI.SetActive(false);
        blackPanel.SetActive(false);

        pausedMusic.Stop();
        backgroundMusic.Play();

        Time.timeScale = 1f;
        isGamePuased = false;

        SceneManager.LoadScene("StartMenu");
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
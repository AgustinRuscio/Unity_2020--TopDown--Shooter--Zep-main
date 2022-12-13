//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioSource audioSource;
    AudioSource music;

    public checkpointUpdater checkpoint;

    private void Start()
    {
        music = FindObjectOfType<AudioSource>();
    }

    public void loadScene(string sceneName)
    {
        music.Stop();
        SceneManager.LoadScene(sceneName);
    }

    public void credit()
    {
        music.Stop();
        SceneManager.LoadScene("credits");
    }

    public void exitGame()
    {
        music.Stop();
        Application.Quit();
        Debug.Log("Quit");
    }   

    public void GoMainmenu()
    {
        music.Stop();
        SceneManager.LoadScene("StartMenu");
    }

    public void TryAgainButton()
    {
        music.Stop();
        SceneManager.LoadScene(PlayerPrefs.GetString("currentLevel"));
    }
}

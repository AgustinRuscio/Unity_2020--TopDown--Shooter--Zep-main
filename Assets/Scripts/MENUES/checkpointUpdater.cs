//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpointUpdater : MonoBehaviour
{
    public string chepointName;

    Scene currentScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            currentScene = SceneManager.GetActiveScene();
            chepointName = currentScene.name;
        }
    }          
}

//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Tutorial")
                SceneManager.LoadScene("Level1");
            else if (SceneManager.GetActiveScene().name == "Level1")
                SceneManager.LoadScene("Level2");
            else if (SceneManager.GetActiveScene().name == "Level2")
                SceneManager.LoadScene("win");
        } 
    }
}

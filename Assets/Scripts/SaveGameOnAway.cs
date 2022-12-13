//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveGameOnAway : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.SetString("currentLevel", SceneManager.GetActiveScene().name);
        PlayerPrefs.Save();
    }
}

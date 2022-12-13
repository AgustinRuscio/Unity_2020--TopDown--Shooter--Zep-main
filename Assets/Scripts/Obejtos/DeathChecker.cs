//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathChecker : MonoBehaviour
{
    public int enemyInside;
    public int spawnerInside;
    public GameObject paredInvisible;
    public GameObject texto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemigo")
            enemyInside++;

        if (collision.tag == "Spawner")
            spawnerInside++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemigo")
        {
            enemyInside--;
            Debug.Log("Mastaste un enemigo");
        }
        if (collision.tag == "Spawner")
        {
            spawnerInside--;
            Debug.Log("Un spawner fue consumido");
        }

        if (enemyInside <= 0 && spawnerInside <= 0)
        {
            paredInvisible.SetActive(false);
            texto.SetActive(true);
        }
    }
}
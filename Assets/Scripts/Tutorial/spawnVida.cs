//--------------------------------------
//              Ruscio&&Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnVida : MonoBehaviour
{
    public Transform puntoSpawn;
    public GameObject healthKit;

    public GameObject textoVida;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "Player")
            {
                GameObject health = Instantiate(healthKit, puntoSpawn.position, puntoSpawn.rotation);
                textoVida.SetActive(true);
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "Player")
                textoVida.SetActive(false);
        }
    }
}

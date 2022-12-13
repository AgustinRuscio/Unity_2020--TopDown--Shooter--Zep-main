//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBalas : MonoBehaviour
{
    public Transform puntoSpawn;
    public GameObject balas;

    public GameObject TextoAmmo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "Player")
            {
                GameObject bala = Instantiate(balas, puntoSpawn.position, puntoSpawn.rotation);
                TextoAmmo.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "Player")
                TextoAmmo.SetActive(false);     
        }
    }
}

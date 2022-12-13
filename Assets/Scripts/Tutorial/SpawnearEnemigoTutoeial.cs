//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnearEnemigoTutoeial : MonoBehaviour
{
    public Transform puntoSpawn;
    public GameObject Enemy;

    public GameObject Texto;

    public GameObject[] Paredes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (puntoSpawn != null)
            if (collision.tag == "Player")
            {
                Texto.SetActive(true);

                GameObject enemy = Instantiate(Enemy, puntoSpawn.position, puntoSpawn.rotation);
                Destroy(gameObject);

                Paredes[0].SetActive(true);
                Paredes[1].SetActive(true);
            }

    }
}

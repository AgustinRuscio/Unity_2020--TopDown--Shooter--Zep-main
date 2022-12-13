//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDettection : MonoBehaviour
{
    public  GameObject bossGO;

    public GameObject healthbarGO;

    private AudioSource gruñido;
    private int gruñidoCount;

    public AudioSource pisadas;

    private void Start()
    {
        gruñido = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Bullets")
        {
            pisadas.Play();

            detectetionActivated();

            if(gruñidoCount <= 0)
            {
                gruñido.Play();
                gruñidoCount++;
            }
        }
    }

    public void detectetionActivated()
    {
        healthbarGO.SetActive(true);

        bossGO.GetComponent<EnemyIA>().finderActivated = true;
        bossGO.GetComponent<lookAtObject>().enabled = true;
    }
}

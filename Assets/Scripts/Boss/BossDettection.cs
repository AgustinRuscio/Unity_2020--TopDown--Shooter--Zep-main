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

    private AudioSource gruņido;
    private int gruņidoCount;

    public AudioSource pisadas;

    private void Start()
    {
        gruņido = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Bullets")
        {
            pisadas.Play();

            detectetionActivated();

            if(gruņidoCount <= 0)
            {
                gruņido.Play();
                gruņidoCount++;
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

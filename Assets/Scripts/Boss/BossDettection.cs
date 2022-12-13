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

    private AudioSource gru�ido;
    private int gru�idoCount;

    public AudioSource pisadas;

    private void Start()
    {
        gru�ido = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Bullets")
        {
            pisadas.Play();

            detectetionActivated();

            if(gru�idoCount <= 0)
            {
                gru�ido.Play();
                gru�idoCount++;
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

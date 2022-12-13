//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witchDetection : MonoBehaviour
{
    private CircleCollider2D myCircleCollider;
    public  GameObject witchGO;

    public  Animator anim;
    public  bool playerDetected;
 
    private AudioSource scream;
    public  AudioSource steep;
    public  AudioSource zombieSound;
    private AudioSource stopCrying;

    int screamCount = 0;

    void Start()
    {
        myCircleCollider = GetComponent<CircleCollider2D>();
        scream = GetComponent<AudioSource>();
        stopCrying = witchGO.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Bullets")
            detectetionActivated();  
    }

    public void detectetionActivated()
    {
        stopCrying.Stop();

        steep.Play();
        zombieSound.Play();

        if (screamCount <= 0)
        {
            scream.Play();
            screamCount++;
        }

        playerDetected = true;

        anim.SetBool("Detected", playerDetected);

        witchGO.GetComponent<EnemyIA>().finderActivated = true;
        witchGO.GetComponent<lookAtObject>().enabled = true;
    }
}

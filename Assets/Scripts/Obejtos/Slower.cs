//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : MonoBehaviour
{
    public float reducer = 2.5f;

    public AudioSource soundMud;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        soundMud.Play();

        PlayerController playerController = collision.GetComponent<PlayerController>();
        playerController.moveSpeed -= reducer;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        soundMud.Stop();

        PlayerController playerController = collision.GetComponent<PlayerController>();
        playerController.moveSpeed += reducer;
    }
}

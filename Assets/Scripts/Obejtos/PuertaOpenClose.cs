//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaOpenClose : MonoBehaviour
{
    public bool puertaAbierta;
    public GameObject pared;
    public GameObject bloqueador;
    public Sprite[] spritePuerta;

    public AudioSource audioSound;
    private void Start()
    {
        audioSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            puertaAbierta = true ;
            
            audioSound.Play();
        }

        if (collision.tag == "Enemigo")
        {
            puertaAbierta = true;
            audioSound.Play();
        }
    }

   private void OnTriggerExit2D(Collider2D collision)
   {
        if (collision.tag == "Player")
        {
            puertaAbierta = false;

            audioSound.Play();
        }

        if (collision.tag == "Enemigo")
        {
            puertaAbierta = false;

            audioSound.Play();
        }
   }

   private void Update()
   {
        if (puertaAbierta == true )
            this.GetComponent<SpriteRenderer>().sprite = spritePuerta[1];
        else
            this.GetComponent<SpriteRenderer>().sprite = spritePuerta[0]; 
   }
}
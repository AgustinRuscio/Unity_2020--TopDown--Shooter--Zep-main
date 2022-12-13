//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicMud : MonoBehaviour
{
    public int reducer = 50;

    public AudioSource soundMud;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            soundMud.Play();

            enemyLife enemyLife = collision.GetComponent<enemyLife>();
            enemyLife.life -= reducer;

            if(enemyLife.life<= 0)
                enemyLife.die();  
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            soundMud.Stop();    
    }
}

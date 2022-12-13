//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAreaCheckerLv2 : MonoBehaviour
{
    public int enemyInside;

    public GameObject bloqueadorUno;
    public GameObject bloqueadorDos;
    public GameObject bloqueadorEnemies;

    public GameObject texto;

    void Start() 
    {
        bloqueadorEnemies.SetActive(true);
    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemigo" || collision.tag == "Witch" || collision.tag == "Boss")
            enemyInside++;         
              
        if (collision.tag == "Player")
        {
            bloqueadorUno.SetActive(true);
            bloqueadorDos.SetActive(true);
            bloqueadorEnemies.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemigo" && (enemyInside-1) >= 0 || collision.tag == "Witch" && (enemyInside - 1) >= 0 || collision.tag == "Boss" && (enemyInside - 1) >= 0)
        {
            enemyInside--;

            if (enemyInside == 0)
            {
                texto.SetActive(true);
                Destroy(bloqueadorUno);
                Destroy(bloqueadorDos);
                Destroy(this.gameObject);
            }
        }        
    }
}

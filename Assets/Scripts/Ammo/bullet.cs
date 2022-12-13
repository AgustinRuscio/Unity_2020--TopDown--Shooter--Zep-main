//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "Enemigo")
            {
                enemyLife sustractLife = collision.GetComponent<enemyLife>();
                sustractLife.life -= damage;
                Destroy(this.gameObject);

                if (sustractLife.life <= 0)
                    sustractLife.die();    
            }
            else if (collision.tag == "Witch")
            {
                WitchLife sustractLife = collision.GetComponent<WitchLife>();
                sustractLife.life -= damage;
                Destroy(this.gameObject);

                if (sustractLife.life <= 0)
                    sustractLife.die();
            }
            else if (collision.tag == "Player")
            {
                
                enemyLife sustractLife = collision.GetComponent<enemyLife>();
                sustractLife.life -= damage;

                AudioSource RecibirDañoPlayer = collision.GetComponent<AudioSource>();
                RecibirDañoPlayer.Play();
                
                Destroy(this.gameObject);

                if (sustractLife.life <= 0)                
                    sustractLife.die();
            }
            else if (collision.tag == "Boss")
            {
                BossLife bossLife = collision.GetComponent<BossLife>();
                bossLife.life -= damage;

                if (bossLife.life <= 0)
                    bossLife.die();

                Destroy(this.gameObject);
            }
            else if (collision.tag != "DeathCheker")
                Destroy(this.gameObject);         
        }
    } 
}

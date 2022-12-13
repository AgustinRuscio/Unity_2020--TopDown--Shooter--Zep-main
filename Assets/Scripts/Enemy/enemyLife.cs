//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyLife : MonoBehaviour
{
    public int life;
    public int maxLife = 100;

    public AudioSource enemyDieSound;
    public AudioSource playerDieSound;

    public HealthBar HealthBar;

    private int itemSpawnCounter = 0;
    public  GameObject [] itemList;
    private int itemNum; 
    private int randNum; 
    private Transform Epos; 

    public Transform SpawnPointDrops;

    public Animator animDeathEnemy;
    private bool setDeath;

    public enemyShoot shoot;
    public CircleCollider2D myCollider;
    public PlayerController playerController;

    private void Start()
    {
        life = maxLife; 
    }
  
    public void die ()
    {
        if (life <= 0)
        {
            if (this.gameObject.tag == "Player")
            {
                myCollider.enabled = false;
                playerDieSound.Play();
                
                playerController.enabled = false;
                StartCoroutine("WaitForPlayerToDie",playerDieSound);    
            }
            else 
            {
                Epos = GetComponent<Transform>();

                randNum = Random.Range(0, 100);

                if (itemSpawnCounter == 0 )
                {
                    if (randNum >= 75)
                    {
                        itemNum = Random.Range(0, 3);
                        Instantiate(itemList[itemNum], Epos.position, Quaternion.identity);
                        itemSpawnCounter++;               
                    }
                    else
                    { }
                }
                
                enemyDieSound.Play();
                setDeath = true;
                
                shoot.enabled = false;
                animDeathEnemy.SetBool("DeathEnemy", setDeath);
                StartCoroutine(WaitForDestroy(enemyDieSound));
            }
        } 
    }

    public IEnumerator WaitForPlayerToDie (AudioSource Sound)
    {
        yield return new WaitUntil(() => playerDieSound.isPlaying == false);
        gameObject.SetActive(false);
        SceneManager.LoadScene("gameOver");
    }

    public IEnumerator WaitForDestroy(AudioSource Sound)
    {
        yield return new WaitUntil(() => enemyDieSound.isPlaying == false);
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}

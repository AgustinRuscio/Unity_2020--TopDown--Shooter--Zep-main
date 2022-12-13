//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchLife : MonoBehaviour
{
    public AudioSource enemyDieSound;
    public Animator animDeathEnemy;
    public CircleCollider2D myCollider;

    private bool setDeath;

    public witchAttack attack;
    public witchDetection Detection;

    public int life;

    public int maxLife = 1000;

    void Start()
    {   
        life = maxLife;
    }

    public void die()
    {
        if (life <= 0)
        {
            attack.gameObject.SetActive(false);
            Detection.gameObject.SetActive(false);

            myCollider.enabled = false;
            enemyDieSound.Play();
            setDeath = true;
            animDeathEnemy.SetBool("DeathEnemy", setDeath);
            StartCoroutine(WaitForDestroy(enemyDieSound));
        }
    }

    public IEnumerator WaitForDestroy(AudioSource Sound)
    {
        yield return new WaitUntil(() => enemyDieSound.isPlaying == false);
        gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}

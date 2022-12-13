using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDie : MonoBehaviour
{
    public AudioSource enemyDieSound;
    public Animator animDeathEnemy;

    private bool setDeath;
    public enemyLife die;

    public GameObject witchGO;
    public witchAttack attack;
    public witchDetection Detection;

    void Update()
    {
        if (die.life <= 0)
        {
            attack.gameObject.SetActive(false);
            Detection.gameObject.SetActive(false);

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
        Destroy(witchGO);
    }
}

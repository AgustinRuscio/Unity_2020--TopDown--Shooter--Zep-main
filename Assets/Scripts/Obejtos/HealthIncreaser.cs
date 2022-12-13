//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncreaser : MonoBehaviour
{
    public int healthtoSum;
    public BoxCollider2D myClider;

    public AudioSource healthsource;
    public AudioClip healthclip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.tag == "Player")
            {
                healthsource.Play();
                StartCoroutine(WaitForSound(healthclip));

                enemyLife addLife = collision.GetComponent<enemyLife>();

                if ((addLife.life + healthtoSum) < addLife.maxLife)
                    addLife.life += healthtoSum;
                else if ((addLife.life + healthtoSum) >= addLife.maxLife)
                    addLife.life = addLife.maxLife;

                Debug.Log("Agarraste un curador, ahora tenés: " + addLife.life + " de vida");
            }
        }
    }

    public IEnumerator WaitForSound(AudioClip Sound)
    {
        myClider.enabled = false;
        yield return new WaitUntil(() => healthsource.isPlaying == false);
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
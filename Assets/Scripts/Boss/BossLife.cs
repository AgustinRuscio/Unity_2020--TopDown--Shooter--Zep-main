//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour
{
    public int life;

    public int maxLife = 1000;

    public BossHealthBar HealthBar;

    public GameObject Enemy;

    public Transform puntosSpwan1;
    public Transform puntosSpwan2;
    public Transform puntosSpwan3;
    public Transform puntosSpwan4;

    public BossAttack attack;
    public BossDettection Detection;

    public float AttackCoolDown;
    public float CoolDownRestante;

    public Animator AnimBoss;
    private bool setDeath;

    public BoxCollider2D myCollider;

    public AudioSource Muerte;

    private void Start()
    {
        life = maxLife;

        InvokeRepeating("SpawnEnemies", 0f, 0.01f);

        CoolDownRestante = AttackCoolDown;
    }

    public void die()
    {
        if (life <= 0)
        {
            attack.gameObject.SetActive(false);
            Detection.gameObject.SetActive(false);
            myCollider.enabled = false;

            Muerte.Play();

            setDeath = true;
            AnimBoss.SetBool("Die", setDeath);
            StartCoroutine(WaitForDestroy(Muerte));
        }
    }

    public void SpawnEnemies()
    {
        if (CoolDownRestante > 0f)
            CoolDownRestante -= Time.deltaTime;
        else
        {
            if (life == 2100)
            {
                GameObject enemy  = Instantiate(Enemy, puntosSpwan1.position, puntosSpwan1.rotation);
                GameObject enemy1 = Instantiate(Enemy, puntosSpwan2.position, puntosSpwan2.rotation);
                GameObject enemy2 = Instantiate(Enemy, puntosSpwan3.position, puntosSpwan3.rotation);
                GameObject enemy3 = Instantiate(Enemy, puntosSpwan4.position, puntosSpwan4.rotation);
                CoolDownRestante = AttackCoolDown;
            }
            else if(life == 1500)
            {
                GameObject enemy = Instantiate(Enemy, puntosSpwan1.position, puntosSpwan1.rotation);
                GameObject enemy1 = Instantiate(Enemy, puntosSpwan2.position, puntosSpwan2.rotation);
                GameObject enemy2 = Instantiate(Enemy, puntosSpwan3.position, puntosSpwan3.rotation);
                GameObject enemy3 = Instantiate(Enemy, puntosSpwan4.position, puntosSpwan4.rotation);
                CoolDownRestante = AttackCoolDown;
            }
            else if (life == 900)
            {
                GameObject enemy = Instantiate(Enemy, puntosSpwan1.position, puntosSpwan1.rotation);
                GameObject enemy1 = Instantiate(Enemy, puntosSpwan2.position, puntosSpwan2.rotation);
                GameObject enemy2 = Instantiate(Enemy, puntosSpwan3.position, puntosSpwan3.rotation);
                GameObject enemy3 = Instantiate(Enemy, puntosSpwan4.position, puntosSpwan4.rotation);
                CoolDownRestante = AttackCoolDown;
            }
        }
    }

    public IEnumerator WaitForDestroy(AudioSource Sound)
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);

        Destroy(gameObject);
    }
}

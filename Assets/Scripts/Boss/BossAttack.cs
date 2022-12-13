//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    private int updateChecker = 0;

    public float AttackCoolDown;
    public float CoolDownRestante;

    public enemyLife playerLife;

    public Animator anim;
    
    private bool playerOnAttackRange;

    public int damage = 35;

    public shieldFunction escudo;

    private AudioSource attackSound;

    void Start()
    {
        CoolDownRestante = AttackCoolDown;
        attackSound = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (CoolDownRestante  > 0f)
            CoolDownRestante -= Time.deltaTime;

        if (updateChecker == 0)
            PlayerLeftRange();
        else
            PlayerOnRange();   
    }

    void PlayerOnRange()
    {
        if (escudo.gameObject.activeInHierarchy == false)
        {
            if (CoolDownRestante > 0f)
            {
                CoolDownRestante -= Time.deltaTime;

                playerOnAttackRange = false;
                anim.SetBool("PlayerOnAttackRange", playerOnAttackRange);
            }
            else
            {
                playerOnAttackRange = true;
                anim.SetBool("PlayerOnAttackRange", playerOnAttackRange);

                
                playerLife.life -= damage;
                
                CoolDownRestante = AttackCoolDown;

                attackSound.Play();

                if (playerLife.life <= 0)
                    playerLife.die();
            }
        }
    }

    void PlayerLeftRange()
    {
        playerOnAttackRange = false;

        anim.SetBool("PlayerOnAttackRange", playerOnAttackRange);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            updateChecker = 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            updateChecker = 0;
    }
}
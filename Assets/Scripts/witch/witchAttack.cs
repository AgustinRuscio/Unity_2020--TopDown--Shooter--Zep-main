//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witchAttack : MonoBehaviour
{
    public int updateCheck;

    public float AttackCoolDown;
    public float CoolDownRestante;

    public Animator anim;
    public bool playerOnAttackRange;

    private AudioSource attackSound;

    private int damage = 35;

    public shieldFunction escudo;
    public enemyLife playerLife;

    private void Start()
    {
        CoolDownRestante    = AttackCoolDown;
        attackSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (CoolDownRestante > 0f)
            CoolDownRestante -= Time.deltaTime;       

        if (updateCheck == 0)
            playerLeftRange();  
        else 
            PlayerOnRange();      
    }

    private void PlayerOnRange()
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
                anim.SetBool("AttackRange", playerOnAttackRange);

                attackSound.Play();

                playerLife.life -= damage;

                CoolDownRestante = AttackCoolDown;

                if (playerLife.life <= 0)
                    playerLife.die();
            }
        }
    }

    private void playerLeftRange()
    {
        playerOnAttackRange = false;
        anim.SetBool("AttackRange", playerOnAttackRange);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            updateCheck = 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            updateCheck = 0;
    }
}

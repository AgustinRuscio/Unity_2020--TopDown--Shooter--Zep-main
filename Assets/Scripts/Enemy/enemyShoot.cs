//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public float AttackCoolDown;
    public float CoolDownRestante;

    public GameObject BulletEnemy;
    public Transform firePoint;
    public float fireForce = 20f;

    private void Start()
    {
        CoolDownRestante = AttackCoolDown;
    }

    void Update()
    {
        if (CoolDownRestante > 0f)
            CoolDownRestante -= Time.deltaTime;      
        else
        {
            GameObject bullet = Instantiate(BulletEnemy, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
            CoolDownRestante = AttackCoolDown;
        }
    }
}

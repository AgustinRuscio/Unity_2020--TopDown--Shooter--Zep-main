//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float AttackCoolDown;
    public float CoolDownRestante;

    private void Start()
    {
        CoolDownRestante = AttackCoolDown;
    }

    private void Update()
    {
        if (CoolDownRestante > 0f)      
            CoolDownRestante -= Time.deltaTime;    
        else
        {
            Instantiate(bulletPrefab);
            CoolDownRestante = AttackCoolDown;
        }
    }
}

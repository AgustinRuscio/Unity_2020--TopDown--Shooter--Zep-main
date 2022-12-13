//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float AttackCoolDown;
    public float CoolDownRestante;

    public int enemyReady;

    public GameObject Enemy;
    public Transform SpawnPoint;

    private void Start()
    {
        CoolDownRestante = AttackCoolDown;
    }

    void Update()
    {
        if(enemyReady >0)
        {
            if (CoolDownRestante > 0f)
                CoolDownRestante -= Time.deltaTime;
            else
            {
                GameObject enemy = Instantiate(Enemy, SpawnPoint.position, SpawnPoint.rotation);
                CoolDownRestante = AttackCoolDown;
                enemyReady--;
            }
        }
        else
            Destroy(gameObject);     
    }
}

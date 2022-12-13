//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectAmmo : MonoBehaviour
{  
    public int balas;

    public PlayerController balass;

    public BulletCounter bulletTex;

    public void IncreaseAmmo(int ammoToSumm)
    {
        balass.ammoReady += ammoToSumm;

        bulletTex.UpdateCounter(balass.ammoReady);

        Debug.Log("ahora tenes " + balass.ammoReady + " balas ");
    }
}

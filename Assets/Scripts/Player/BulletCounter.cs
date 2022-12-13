//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
    public Text counter;

    public void UpdateCounter(int currentBullets)
    {
        counter.text =  currentBullets + "";
    }
}

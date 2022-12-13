//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fillImage;

    public enemyLife playerLife;

    public void Update()
    {
        fillImage.fillAmount = (float)playerLife.life / playerLife.maxLife;
    }
}

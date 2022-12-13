//--------------------------------------
//              Ruscio && Riego
//--------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Image fillImage;

    public BossLife bossLife;

    public void Update()
    {
        fillImage.fillAmount = (float)bossLife.life / bossLife.maxLife;
    }
}
